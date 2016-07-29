using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_count.exercism.io
{
    public class Phrase
    {
        private string _IgnoredCharacters = ":!&@$%^.";

        public Dictionary<string, int> WordCount(string phrase)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            phrase = RemoveIgnoredCharacters(phrase);

            phrase = phrase.Replace(',', ' ');

            phrase = phrase.ToLower();

            string[] words = phrase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                //Skips free standing apostrophes
                if ((word == "'") || (word == "''"))
                    continue;

                string tempWord = word;
                //Removing apostrophes as quotes
                if (word.StartsWith("'"))
                    tempWord = word.Remove(0, 1);

                if (word.EndsWith("'"))
                    tempWord = word.Remove(word.Length - 1, 1);

                if (counts.ContainsKey(tempWord))
                {
                    counts[tempWord]++;
                }
                else
                {
                    counts.Add(tempWord, 1);
                }
            }

            return counts;
        }

        private string RemoveIgnoredCharacters(string phrase)
        {
            foreach (char ch in phrase)
            {
                if (_IgnoredCharacters.Contains(ch))
                {
                    phrase = phrase.Remove(phrase.IndexOf(ch), 1);
                }
            }
            return phrase;
        }
    }
}