using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamming.exercism.io
{
    public class Hamming
    {
        public int Compute(string dnaStrand1, string dnaStrand2)
        {
            int hammingDistance = 0;

            if ((dnaStrand1.Length == dnaStrand2.Length) &&
                (dnaStrand1 != dnaStrand2))
            {
                for (int i = 0; i < dnaStrand1.Length; i++)
                {
                    if (dnaStrand1[i] != dnaStrand2[i])
                        hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}
