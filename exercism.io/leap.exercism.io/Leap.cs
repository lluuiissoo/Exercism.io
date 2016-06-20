using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap.exercism.io
{
    public class Year
    {
        public bool IsLeap(int year)
        {
            bool result = false;

            if (IsXDivisibleByY(year, 100) && IsXDivisibleByY(year, 400))
            {
                result = IsXDivisibleByY(year, 4);
            }
            else
            {
                if (!IsXDivisibleByY(year, 100))
                    result = IsXDivisibleByY(year, 4);
            }

            return result;
        }

        private bool IsXDivisibleByY(int x, int y)
        {
            bool result = false;
            if (x % y == 0)
            {
                result = true;
            }
            
            return result;
        }
    }
}
