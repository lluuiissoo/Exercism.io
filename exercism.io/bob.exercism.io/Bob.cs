using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bob.exercism.io
{
    public class Bob
    {
        private const string _AnswerToQuestion = "Sure.";
        private const string _AnswerToYelling = "Whoa, chill out!";
        private const string _AnswerToNothing = "Fine. Be that way!";
        private const string _AnswerToAnythingElse = "Whatever.";

        public string Hey(string phrase)
        {
            //Nothing
            if (string.IsNullOrWhiteSpace(phrase))
                return _AnswerToNothing;

            //Question with only numbers
            if (phrase.Trim().EndsWith("?"))
            {
                string subStr = phrase.Remove(phrase.Length - 1);
                if (IsDigitOnly(subStr))
                {
                    return _AnswerToQuestion;
                }
            }
            else
            {
                if (IsDigitOnly(phrase))
                {
                    return _AnswerToAnythingElse;
                } 
            }
            
            //Shouting
            if (phrase == phrase.Trim().ToUpper())
                return _AnswerToYelling;

            //Question
            if (phrase.Trim().EndsWith("?"))
                return _AnswerToQuestion;

            return _AnswerToAnythingElse;
        }

        private bool IsDigitOnly(string str)
        {
            char[] specialCharacters = {','};
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && (!char.IsWhiteSpace(c)) && (!specialCharacters.Contains(c)))
                    return false;
            }

            return true;
        }
    }
}
