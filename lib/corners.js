const GROUND_TYPE = 15

const irToCorners = (ir) => {
  const corners = []

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

    for (let h = 0; h < corner.voxels.length; h++) {
      const type = corner.voxels[h]

      if (type === -1) continue

      if (type > ir.types.length) {
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
