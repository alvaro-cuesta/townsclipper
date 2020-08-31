const {
  EMPTY_TYPE,
  GROUND_TYPE,
  MAX_TYPE_COUNT,
  GROUND_HEIGHT,
  MAX_HEIGHT,
} = require('./constants')

const denseToSparse = (dense) => {
  if (dense.types.length > MAX_TYPE_COUNT) {
    throw new Error(`Too many types ${dense.types.length}, max ${MAX_TYPE_COUNT}`)
  }

  const sparse = []

  let x = dense.xInitial

  // Corners
  for (const denseCorner of dense.corners) {
    if (denseCorner.xDelta) {
      x += denseCorner.xDelta
    }

    const y = dense.yInitial + (denseCorner.yOffset || 0)

    // Voxels
    const voxels = {}

    if (denseCorner.hasGround) {
      voxels[GROUND_HEIGHT] = GROUND_TYPE
    }

    if (denseCorner.voxels.length > MAX_HEIGHT) {
      throw new Error(`Too many voxels ${denseCorner.voxels.length}, max ${MAX_HEIGHT}`)
    }

    for (let h = 0; h < denseCorner.voxels.length; h++) {
      const type = denseCorner.voxels[h]

      if (type === EMPTY_TYPE) {
        continue
      }

      if (type >= dense.types.length) {
        throw new Error(`Invalid voxel type ${type} at (${x}, ${y}, ${h + 1}), max ${dense.types.length - 1}`)
      }

      voxels[h + 1] = dense.types[type]
    }

    sparse.push({
      x,
      y,
      voxels,
    })
  }

  return sparse
}

const sparseToDense = (sparse) => {
  const dense = {}

  const sortedSparseCorners = sparse
    .map((sparseCorner) => {
      const groundVoxel = sparseCorner.voxels[GROUND_HEIGHT]

      if (groundVoxel !== undefined && groundVoxel !== GROUND_TYPE) {
        throw new Error(`Trying to set voxel type ${sparseCorner.voxels[0]} on ground, only ${GROUND_TYPE} allowed`)
      }

      return {
        x: sparseCorner.x,
        y: sparseCorner.y,
        hasGround: groundVoxel === GROUND_TYPE,
        voxels: sparseCorner.voxels,
      }
    })
    .filter((sparseCorner) =>
      sparseCorner.hasGround
      || Object.keys(sparseCorner.voxels).length > 0
    )
    .sort((a, b) =>
        a.x < b.x
      ? -1
      : a.x > b.x
      ? +1
      : a.y < b.y
      ? -1
      : a.y > b.y
      ? +1
      : 0  // TODO: Throw here? We shouldn't have two corners with the same coordinates. Merge maybe?
    )

  // Analyze voxels for yInitial and types
  let minY = +Infinity
  const types = []

  for (const sparseCorner of sortedSparseCorners) {
    minY = Math.min(minY, sparseCorner.y)

    for (const [heightString, type] of Object.entries(sparseCorner.voxels)) {
      const height = Number(heightString)

      if (height.toString() !== heightString) {
        throw new Error(`Voxel height ${heightString} is not a number`)
      }

      if (!Number.isInteger(type)) {
        throw new Error(`Voxel type ${type} is not a number`)
      }

      if (!types.includes(type) && (height !== GROUND_HEIGHT || type !== GROUND_TYPE)) {
        types.push(type)
      }
    }
  }

  dense.xInitial = sortedSparseCorners[0].x
  dense.yInitial = minY
  dense.types = types.sort((a, b) => a < b ? -1 : a > b ? 1 : 0)

  // Corners
  dense.corners = []

  let currentX = dense.xInitial

  for (const sparseCorner of sortedSparseCorners) {
    const xDelta = dense.corners.length !== 0
      ? sparseCorner.x - currentX
      : null

    currentX = sparseCorner.x

    const yOffset = sparseCorner.y - dense.yInitial

    const maxHeight = Math.max(...Object.keys(sparseCorner.voxels))

    if (maxHeight > MAX_HEIGHT) {
      throw new Error(`Invalid height ${maxHeight}, max ${MAX_HEIGHT}`)
    }

    const voxels = []

    for (let i = (GROUND_HEIGHT + 1); i <= maxHeight; i++) {
      const type = sparseCorner.voxels[i]

      if (type === undefined) {
        voxels.push(-1)
      } else {
        voxels.push(types.indexOf(type))
      }
    }

    dense.corners.push({
      xDelta,
      yOffset,
      hasGround: sparseCorner.hasGround,
      voxels,
    })
  }

  return dense
}

module.exports = {
  denseToSparse,
  sparseToDense,
}
