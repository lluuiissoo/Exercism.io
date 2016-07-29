using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nucleotide_count.exercism.io
{
    public class DNA
    {
        public Dictionary<char, int> NucleotideCounts { get; set; }

        public DNA(string str)
        {
            NucleotideCounts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };

            foreach (char c in str.ToUpper())
            {
                if (NucleotideCounts.ContainsKey(c))
                    NucleotideCounts[c]++;
            }
        }

        public int Count(char nucleodite)
        {
            if (!NucleotideCounts.ContainsKey(nucleodite))
                throw new InvalidNucleotideException();

            return NucleotideCounts[nucleodite];
        }
    }

    public class InvalidNucleotideException : Exception
    {
    }
}