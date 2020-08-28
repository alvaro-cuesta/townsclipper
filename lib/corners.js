const { EMPTY_TYPE, GROUND_TYPE, MAX_TYPE_COUNT, MAX_HEIGHT } = require('./constants')

const irToCorners = (ir) => {
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

module.exports = {
  irToCorners,
}
