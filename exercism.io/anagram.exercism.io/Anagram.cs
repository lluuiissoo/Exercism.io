using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram.exercism.io
{
    public class Anagram
    {
        private string _word = string.Empty;

        public Anagram(string word)
        {
            _word = word;
        }

        public string[] Match(string[] words)
        {
            List<string> anagrams = new List<string>();

            foreach (string word in words)
            {
                if ((word.Length == _word.Length) &&
                    (word.ToLower() != _word.ToLower()))
                {
                    string tempWord = _word.ToLower();
                    bool isAnagram = true;
                    foreach (char character in word.ToLower())
                    {
                        if (tempWord.Contains(character))
                        {
                            tempWord = tempWord.Remove(tempWord.IndexOf(character), 1);
                        }
                        else
                        {
                            isAnagram = false;
                            break;
                        }
                    }

                    if (isAnagram)
                        anagrams.Add(word);
                }
            }

            return anagrams.ToArray();
        }
    }
}
