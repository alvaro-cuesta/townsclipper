const {
  denseToSparse,
  sparseToDense,
} = require('./dense-sparse')

describe('denseToSparse', () => {
  it('Reads voxels types correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: false,
          voxels: [ 0, 1, 0 ],
        }
      ],
    }))
      .toEqual([ { x: 0, y: 0, voxels: { 1: 12, 2: 7, 3: 12 } } ])
  })

  it('Reads ground correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [],
        }
      ],
    }))
      .toEqual([ { x: 0, y: 0, voxels: { 0: 15 } } ])
  })

  it('Reads mixed grounds + voxels types correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 1, 0 ],
        }
      ],
    }))
      .toEqual([ { x: 0, y: 0, voxels: { 0: 15, 1: 12, 2: 7, 3: 12 } } ])
  })

  it('Handles skipped voxels correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: false,
          voxels: [ 0, -1, -1, 1, -1, -1, -1, -1, 0, -1, -1, -1 ],
        }
      ],
    }))
      .toEqual([ { x: 0, y: 0, voxels: { 1: 12, 4: 7, 9: 12 } } ])
  })

  it('Handles skipped voxels with ground correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, -1, -1, 1, -1, -1, -1, -1, 0, -1, -1, -1 ],
        }
      ],
    }))
      .toEqual([ { x: 0, y: 0, voxels: { 0: 15, 1: 12, 4: 7, 9: 12 } } ])
  })

  it('Handles xDelta correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 0, 1 ],
        },
        {
          xDelta: 1337,
          yOffset: 0,
          hasGround: false,
          voxels: [ 0, 1, 0 ],
        },
        {
          xDelta: 1,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 1, 1 ],
        }
      ],
    }))
      .toEqual([
        { x: 0, y: 0, voxels: { 0: 15, 1: 12, 2: 12, 3: 7 } },
        { x: 1337, y: 0, voxels: { 1: 12, 2: 7, 3: 12 } },
        { x: 1338, y: 0, voxels: { 0: 15, 1: 12, 2: 7, 3: 7 } },
      ])
  })

  it('Handles yOffset correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 0, 1 ],
        },
        {
          xDelta: 0,
          yOffset: 10,
          hasGround: false,
          voxels: [ 0, 1, 0 ],
        },
        {
          xDelta: 0,
          yOffset: 20,
          hasGround: true,
          voxels: [ 0, 1, 1 ],
        }
      ],
    }))
      .toEqual([
        { x: 0, y: 0, voxels: { 0: 15, 1: 12, 2: 12, 3: 7 } },
        { x: 0, y: 10, voxels: { 1: 12, 2: 7, 3: 12 } },
        { x: 0, y: 20, voxels: { 0: 15, 1: 12, 2: 7, 3: 7 } },
      ])
  })

  it('Handles xDelta + yOffset correctly', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 0, 1 ],
        },
        {
          xDelta: 1337,
          yOffset: 10,
          hasGround: false,
          voxels: [ 0, 1, 0 ],
        },
        {
          xDelta: 1,
          yOffset: 20,
          hasGround: true,
          voxels: [ 0, 1, 1 ],
        }
      ],
    }))
      .toEqual([
        { x: 0, y: 0, voxels: { 0: 15, 1: 12, 2: 12, 3: 7 } },
        { x: 1337, y: 10, voxels: { 1: 12, 2: 7, 3: 12 } },
        { x: 1338, y: 20, voxels: { 0: 15, 1: 12, 2: 7, 3: 7 } },
      ])
  })

  it('Handles xDelta + yOffset with xInitial set', () => {
    expect(denseToSparse({
      xInitial: 100,
      yInitial: 0,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 0, 1 ],
        },
        {
          xDelta: 1337,
          yOffset: 10,
          hasGround: false,
          voxels: [ 0, 1, 0 ],
        },
        {
          xDelta: 1,
          yOffset: 20,
          hasGround: true,
          voxels: [ 0, 1, 1 ],
        }
      ],
    }))
      .toEqual([
        { x: 100, y: 0, voxels: { 0: 15, 1: 12, 2: 12, 3: 7 } },
        { x: 1437, y: 10, voxels: { 1: 12, 2: 7, 3: 12 } },
        { x: 1438, y: 20, voxels: { 0: 15, 1: 12, 2: 7, 3: 7 } },
      ])
  })

  it('Handles xDelta + yOffset with yInitial set', () => {
    expect(denseToSparse({
      xInitial: 0,
      yInitial: 100,
      types: [12, 7],
      corners: [
        {
          xDelta: null,
          yOffset: 0,
          hasGround: true,
          voxels: [ 0, 0, 1 ],
        },
        {
          xDelta: 1337,
          yOffset: 10,
          hasGround: false,
          voxels: [ 0, 1, 0 ],
        },
        {
          xDelta: 1,
          yOffset: 20,
          hasGround: true,
          voxels: [ 0, 1, 1 ],
        }
      ],
    }))
      .toEqual([
        { x: 0, y: 100, voxels: { 0: 15, 1: 12, 2: 12, 3: 7 } },
        { x: 1337, y: 110, voxels: { 1: 12, 2: 7, 3: 12 } },
        { x: 1338, y: 120, voxels: { 0: 15, 1: 12, 2: 7, 3: 7 } },
      ])
  })

  describe('Invalid input. Throws when...', () => {
    it('...there are too many types', () => {
      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15],
        voxels: [],
      }))
        .toThrow('Too many types (16), max 15')
    })

    it('...there is a corner with too many voxels', () => {
      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: Array(256).fill().map(_ => 0)
          }
        ],
      }))
        .toThrow('Too many voxels (256), max 255')
    })

    it('...there is a corner with an invalid voxel type', () => {
      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: ['foo'],
          }
        ],
      }))
        .toThrow('Invalid voxel type foo at (0, 0, 1)')

      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [undefined],
          }
        ],
      }))
        .toThrow('Invalid voxel type undefined at (0, 0, 1)')

      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [null],
          }
        ],
      }))
        .toThrow('Invalid voxel type null at (0, 0, 1)')

      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [1.4],
          }
        ],
      }))
        .toThrow('Invalid voxel type 1.4 at (0, 0, 1)')
    })

    it('...there is a corner with an out-of-range voxel type', () => {
      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [-2],
          }
        ],
      }))
        .toThrow('Invalid voxel type -2 at (0, 0, 1), min -1, max 0')

      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [2],
          }
        ],
      }))
        .toThrow('Invalid voxel type 2 at (0, 0, 1), min -1, max 0')
    })

    it('...first xDelta is not null', () => {
      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [],
        corners: [
          {
            xDelta: 1337,
            yOffset: 0,
            hasGround: false,
            voxels: [],
          }
        ],
      }))
        .toThrow('First xDelta (1337) is not null')

      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [],
        corners: [
          {
            xDelta: 0,
            yOffset: 0,
            hasGround: false,
            voxels: [],
          }
        ],
      }))
        .toThrow('First xDelta (0) is not null')

      expect(() => denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [],
        corners: [
          {
            xDelta: undefined,
            yOffset: 0,
            hasGround: false,
            voxels: [],
          }
        ],
      }))
        .toThrow('First xDelta (undefined) is not null')
    })
  })

  describe('Empty corner check', () => {
    it('Does not add empty corners', () => {
      expect(denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [],
          }
        ],
      }))
        .toEqual([])
    })

    it('Does add corners with only ground', () => {
      expect(denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: true,
            voxels: [],
          }
        ],
      }))
        .toEqual([{ x: 0, y: 0, voxels: { 0: 15 } }])
    })

    it('Does add corners with only one voxel', () => {
      expect(denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [ 0 ],
          }
        ],
      }))
        .toEqual([{ x: 0, y: 0, voxels: { 1: 0 } }])
    })

    it('Does consider a voxel list with only empties as empty', () => {
      expect(denseToSparse({
        xInitial: 0,
        yInitial: 0,
        types: [0],
        corners: [
          {
            xDelta: null,
            yOffset: 0,
            hasGround: false,
            voxels: [ -1, -1, -1, -1 ],
          }
        ],
      }))
        .toEqual([])
    })
  })
})
