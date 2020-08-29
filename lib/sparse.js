const { EMPTY_TYPE, GROUND_TYPE, MAX_TYPE_COUNT, MAX_HEIGHT } = require('./constants')

const irToSparse = (ir) => {
  const corners = []

  if (ir.types.length > MAX_TYPE_COUNT) {
    throw new Error(`Too many types ${ir.types.length}, max ${MAX_TYPE_COUNT}`)
  }

  let x = ir.xInitial

  for (const corner of ir.corners) {
    if (corner.xDelta) {
      x += corner.xDelta
    }

    const y = ir.yInitial + (corner.yOffset || 0)

    const voxels = {}

    if (corner.hasGround) {
      voxels[0] = GROUND_TYPE
    }

    if (corner.voxels.length > MAX_HEIGHT) {
      throw new Error(`Too many voxels ${corner.voxels.length}, max ${MAX_HEIGHT}`)
    }

    for (let h = 0; h < corner.voxels.length; h++) {
      const type = corner.voxels[h]

      if (type === EMPTY_TYPE) continue

      if (type >= ir.types.length) {
        throw new Error(`Invalid voxel type ${type} at (${x}, ${y}, ${h + 1}), max ${ir.types.length - 1}`)
      }

      voxels[h + 1] = ir.types[type]
    }

    corners.push({
      x,
      y,
      voxels,
    })
  }

  return corners
}

const sparseToIR = (corners) => {
  const ir = {}

  const sortedCorners = corners
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
      : 0  // TODO: Throw here? We shouldn't have two corners with the same coordinates
    )

  // Analyze voxels for yInitial and types
  ir.xInitial = sortedCorners[0].x

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

  ir.yInitial = minY
  ir.types = types.sort((a, b) => a < b ? -1 : a > b ? 1 : 0)

  // Corners
  ir.corners = []

  let currentX = ir.xInitial

  for (const corner of sortedCorners) {
    const xDelta = ir.corners.length !== 0
      ? corner.x - currentX
      : null

    const yOffset = corner.y - ir.yInitial

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

    ir.corners.push({
      xDelta,
      yOffset,
      hasGround,
      voxels,
    })
  }

  return ir
}

module.exports = {
  irToSparse,
  sparseToIR,
}
