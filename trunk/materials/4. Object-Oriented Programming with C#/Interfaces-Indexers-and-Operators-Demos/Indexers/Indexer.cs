using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    struct BitArray32
    {
        private uint bitValues;

        // Indexer declaration
        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index <= 31))
                {
                    // Check the bit at position index
                    if ((bitValues & (1 << index)) == 0)
                        return 0;
                    else
                        return 1;
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!", index));
                }
            }

            set
            {
                if ((index < 0) || (index > 31))
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!", index));
                }
                if ((value < 0) || (value > 1))
                {
                    throw new ArgumentOutOfRangeException(String.Format(
                        "Value {0} is invalid!", value));
                }

                // Clear the bit at position index
                bitValues &= ~((uint)(1 << index));

                // Set the bit at position index to value
                bitValues |= (uint)(value << index);
            }
        }
    }

    class IndexerTest
    {
        static void Main(string[] args)
        {
            BitArray32 arr = new BitArray32();

            arr[0] = 1;
            arr[5] = 1;
            arr[5] = 0;
            arr[25] = 1;
            arr[31] = 1;

            for (int i = 0; i <= 31; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
