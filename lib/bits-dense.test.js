const {
  bitsToDense,
  denseToBits,
} = require('./bits-dense')

describe('bitsToDense', () => {
  it('Can read the default empty value', () => {
    const result = bitsToDense('000' + '10' + '0000' + '00000' + '00000' + '00000')
    expect(result).toEqual({
      xInitial: 0,
      yInitial: 0,
      types: [],
      corners: [],
    })
  })

  describe('Reads initial positions', () => {
    describe('X', () => {
      it('0 bit length, [0, 0]', () => {
        const result = bitsToDense('000' + '10' + '0000' + '00000' + '00000' + /*->*/ '00000' /*<-*/)
        expect(result.xInitial).toEqual(0)
      })

      it('1 bit length, [-1, 0]', () => {
        {
          const result = bitsToDense('0' + '10' + '0000' + '0' +  /*->*/ '1' /*<-*/ + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.xInitial).toEqual(0)
        }

        {
          const result = bitsToDense('0' + '10' + '0000' + '0' +  /*->*/ '0' /*<-*/ + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.xInitial).toEqual(-1)
        }
      })

      it('5 bit length, [-16, 15]', () => {
        {
          const result = bitsToDense('00000' + '10' + '0000' + '00000' + /*->*/ '11111' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(15)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + '00000' + /*->*/ '10000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(0)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + '00000' + /*->*/ '00000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(-16)
        }
      })
    })

    describe('Y', () => {
      it('0 bit length, [0, 0]', () => {
        const result = bitsToDense('000' + '10' + '0000' + '00000' + '00000' + /*->*/ '00000' /*<-*/)
        expect(result.yInitial).toEqual(0)
      })

      it('1 bit length, [-1, 0]', () => {
        {
          const result = bitsToDense('0' + '10' + '0000' + /*->*/ '1' /*<-*/ + '0' + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.yInitial).toEqual(0)
        }

        {
          const result = bitsToDense('0' + '10' + '0000' + /*->*/ '0' /*<-*/ + '0' + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.yInitial).toEqual(-1)
        }
      })

      it('5 bit length, [-16, 15]', () => {
        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '11111' /*<-*/ + '00000' + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.yInitial).toEqual(15)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '10000' /*<-*/ + '00000' + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.yInitial).toEqual(0)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '00000' /*<-*/ + '00000' + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.yInitial).toEqual(-16)
        }
      })
    })

    describe('X + Y', () => {
      it('0 bit length, [0, 0]', () => {
        const result = bitsToDense('000' + '10' + '0000' + '00000' + '00000' + /*->*/ '00000' /*<-*/)
        expect(result.xInitial).toEqual(0)
        expect(result.yInitial).toEqual(0)
      })

      it('1 bit length, [-1, 0]', () => {
        {
          const result = bitsToDense('0' + '10' + '0000' + /*->*/ '1' + '1' /*<-*/ + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.xInitial).toEqual(0)
          expect(result.yInitial).toEqual(0)
        }

        {
          const result = bitsToDense('0' + '10' + '0000' + /*->*/ '1' + '0' /*<-*/ + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.xInitial).toEqual(-1)
          expect(result.yInitial).toEqual(0)
        }

        {
          const result = bitsToDense('0' + '10' + '0000' + /*->*/ '0' + '1' /*<-*/ + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.xInitial).toEqual(0)
          expect(result.yInitial).toEqual(-1)
        }

        {
          const result = bitsToDense('0' + '10' + '0000' + /*->*/ '0' + '0' /*<-*/ + '00000' + '00000' + /*->*/ '00001' /*<-*/)
          expect(result.xInitial).toEqual(-1)
          expect(result.yInitial).toEqual(-1)
        }
      })

      it('5 bit length, [-16, 15]', () => {
        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '11111' + '00000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(-16)
          expect(result.yInitial).toEqual(15)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '10000' + '10000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(0)
          expect(result.yInitial).toEqual(0)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '00000' + '00000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(-16)
          expect(result.yInitial).toEqual(-16)
        }
        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '00000' + '11111' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(15)
          expect(result.yInitial).toEqual(-16)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '10000' + '10000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(0)
          expect(result.yInitial).toEqual(0)
        }

        {
          const result = bitsToDense('00000' + '10' + '0000' + /*->*/ '00000' + '00000' /*<-*/ + '00000' + '00000' + /*->*/ '00101' /*<-*/)
          expect(result.xInitial).toEqual(-16)
          expect(result.yInitial).toEqual(-16)
        }
      })
    })
  })

  describe('Reads type list', () => {
    it('Length', () => {
      {
        const result = bitsToDense('000' + '10' + /*->*/ '0000' /*<-*/ + '00000' + '00000' + '00000')
        expect(result.types).toHaveLength(0)
      }

      {
        const result = bitsToDense('000' + '10' + '0000' + '0001' + '0011' + /*->*/ '0011' /*<-*/ + '00000' + '00000' + '00000')
        expect(result.types).toHaveLength(3)
      }
    })


    it('Contents', () => {
      {
        const result = bitsToDense('000' + '10' + /*->*/ /*<-*/ '0000' + '00000' + '00000' + '00000')
        expect(result.types).toEqual([])
      }

      {
        const result = bitsToDense('000' + '10' + /*->*/ '0000' + '0001' + '0011' + /*<-*/ '0011' + '00000' + '00000' + '00000')
        expect(result.types).toEqual([ 3, 1, 0 ])
      }
    })
  })

  describe('Invalid input. Throws when...', () => {
    it('...receiving an invalid character', () => {
      expect(() => bitsToDense('??'))
        .toThrow('Invalid bit character ?')
      expect(() => bitsToDense('A'))
        .toThrow('Invalid bit character A')
      expect(() => bitsToDense('001000A'))
        .toThrow('Invalid bit character A')
      expect(() => bitsToDense('A000100'))
        .toThrow('Invalid bit character A')
    })

    it('...receiving wrong padding', () => {
      expect(() => bitsToDense('0000'))
        .toThrow('Bit string length (4) must be a multiple of 6')
      expect(() => bitsToDense('0000000000'))
        .toThrow('Bit string length (10) must be a multiple of 6')
      expect(() => bitsToDense('0001'))
        .toThrow('Bit string length (4) must be a multiple of 6')
      expect(() => bitsToDense('1000000'))
        .toThrow('Bit string length (7) must be a multiple of 6')
      expect(() => bitsToDense('11011101110100001101101100010100000111110011010101101101100011110101110011100111111110100101011111000101111100101111000'))
        .toThrow('Bit string length (119) must be a multiple of 6')
    })

    /*

    No way to test for now. See MAX_TYPE comment in constants.js

    it('...receiving an invalid voxel type', () => {

    })

    */
  })
})


describe('denseToBits', () => {
  it('Correctly handles the empty case', () => {
    {
      const result = denseToBits({
        xInitial: 0,
        yInitial: 0,
        types: [],
        corners: [],
      })

      expect(result).toEqual('000100000000000000000000')
    }
  })
})
