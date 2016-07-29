using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace phone_number.exercism.io
{
    public class PhoneNumber
    {
        public string Number { get; set; }

        public string AreaCode { get; set; }

        public PhoneNumber(string number)
        {
            Number = ValidateNumber(number);

            AreaCode = Number.Substring(0, 3);
        }

        private string ValidateNumber(string phoneNumber)
        {
            phoneNumber = RemoveNonDigitCharacters(phoneNumber);

            int digitCount = phoneNumber.Length;

            string invalidPhone = "0000000000";

            if ((digitCount < 10) || (digitCount > 11))
                phoneNumber = invalidPhone;
            else if (digitCount == 11)
                if (phoneNumber[0] == '1')
                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1); //Remove the US code
                else
                    phoneNumber = invalidPhone;

            return phoneNumber;
        }

        private string RemoveNonDigitCharacters(string phoneNumber)
        {
            string nonDigitPattern = @"[^0-9]"; //Matches all non-digit characters
            
            return Regex.Replace(phoneNumber, nonDigitPattern, string.Empty, RegexOptions.None);
        }

        public override string ToString()
        {
            string formattedNumber = string.Format("({0}) {1}-{2}",
                Number.Substring(0, 3), //Area Code
                Number.Substring(3, 3), //First 3 digits
                Number.Substring(6, 4)); //Last 4 digits

            return formattedNumber;
        }
    }
}
