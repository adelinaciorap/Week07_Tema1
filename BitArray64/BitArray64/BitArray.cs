using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class BitArray: IEnumerable<int>
        
    {
        private ulong number;
        private int[]bitArray= new int[64];

        public BitArray(ulong number)
        {
            this.Number = number;
            for (int i=0; i<16; i++)
            {
                bitArray[i] = (int)number % 2;
                number /= 2;
            }
        }

            public ulong Number { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i=63; i >= 0; i--)
            {
                yield return this.bitArray[i];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray bitArray = obj as BitArray;
            if ((object)bitArray == null)
            {
                return false;
            }

            else if(object.Equals(this.number, bitArray.number))
                {
                return true;
                }
            return false;
        }

        public static bool operator == (BitArray first, BitArray second)
        {
            return BitArray.Equals(first, second);
        }
         public static bool operator !=(BitArray first, BitArray second)
        {
            return BitArray.Equals(first, second);
        }

        public int this[int index]
        {
            get { return this.bitArray[index]; }
            set
            {
                if(value==1 || value == 0)
                {
                    this.bitArray[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The value must be [1] or [0].");
                }


            }
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        
    }
}
