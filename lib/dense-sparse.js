const { EMPTY_TYPE, GROUND_TYPE, MAX_TYPE_COUNT, MAX_HEIGHT } = require('./constants')

const denseToSparse = (dense) => {
  if (dense.types.length > MAX_TYPE_COUNT) {
    throw new Error(`Too many types ${dense.types.length}, max ${MAX_TYPE_COUNT}`)
  }

  const sparse = []

  let x = dense.xInitial

  // Corners
  for (const corner of dense.corners) {
    if (corner.xDelta) {
      x += corner.xDelta
    }

    const y = dense.yInitial + (corner.yOffset || 0)

    // Voxels
    const voxels = {}

    if (corner.hasGround) {
      voxels[0] = GROUND_TYPE
    }

    if (corner.voxels.length > MAX_HEIGHT) {
      throw new Error(`Too many voxels ${corner.voxels.length}, max ${MAX_HEIGHT}`)
    }

    for (let h = 0; h < corner.voxels.length; h++) {
      const type = corner.voxels[h]

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

  const sortedCorners = sparse
    .slice()
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
  dense.xInitial = sortedCorners[0].x

  let minY = +Infinity
  const types = []

  for (const corner of sortedCorners) {
    minY = Math.min(minY, corner.y)

    for (const [height, type] of Object.entries(corner.voxels)) {
      if (!types.includes(type) && (type !== 15 || height !== '0')) {
        types.push(type)
      }
    }
  }

  dense.yInitial = minY
  dense.types = types.sort((a, b) => a < b ? -1 : a > b ? 1 : 0)

  // Corners
  dense.corners = []

  let currentX = dense.xInitial

  for (const corner of sortedCorners) {
    const xDelta = dense.corners.length !== 0
      ? corner.x - currentX
      : null

    const yOffset = corner.y - dense.yInitial

    // Voxels
    const hasGround = corner.voxels[0] === GROUND_TYPE

    const maxHeight = Math.max(...Object.keys(corner.voxels))

    const voxels = []

    for (let i = 1; i <= maxHeight; i++) {
      const type = corner.voxels[i]

      if (type === undefined) {
        voxels.push(-1)
      } else {
        voxels.push(types.indexOf(type))
      }
    }

    dense.corners.push({
      xDelta,
      yOffset,
      hasGround,
      voxels,
    })
  }

  return dense
}

module.exports = {
  denseToSparse,
  sparseToDense,
}
