using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem64BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private readonly ulong number;

        public BitArray64(ulong number = 0)
        {
            this.number = number;
        }





        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int[] Bits
        {
            get { return this.ConvertToBits(); }
        }

        private int[] ConvertToBits()
        {
            ulong value = this.number;

            int[] bits = new int[64];
            int counter = 63;

            while (value != 0)
            {
                bits[counter] = (int)value % 2;
                value /= 2;
                counter--;
            }

            do
            {
                bits[counter] = 0;
                counter--;
            }
            while (counter != 0);

            return bits;
        }

        public bool Equals(BitArray64 value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }
            if (ReferenceEquals(this, value))
            {
                return true;
            }
            return this.number == value.number;
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.number.GetHashCode();
                return result;
            }
        }

       private bool IndexChecker(int index)
        {
            if (index < 0 || index > 63)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int this[int index]
        {
            get
            {
                if (IndexChecker(index))
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.ConvertToBits();
                return bits[index];
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public override string ToString()
        {
            return string.Join(", ", number);
        }
    }
}
