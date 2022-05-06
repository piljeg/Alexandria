using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services
{
    public static class ValidationService
    {
        public static bool ParseNumber(string number, out int parsedNumber)
        {
            return int.TryParse(number, out parsedNumber);
        }

        public static bool ParseDoubleNumber(string number, out double parsedNumber)
        {
            return double.TryParse(number, out parsedNumber);
        }

        public static bool AssertPositive(string number)
        {
            if (!ParseNumber(number, out int parsedNumber))
            {
                return false;
            }
            else
            {
                return parsedNumber >= 0 ? true : false;
            }
        }

        public static bool AssertLargerThan(string number, int min)
        {
            if (!ParseNumber(number, out int parsedNumber))
            {
                return false;
            }
            else
            {
                return parsedNumber >= min ? true : false;
            }
        }

        public static bool AssertStringLenght(string input, int lenght)
        {
            return input.Length >= lenght;
        }

        public static bool AssertEmail(string input)
        {
            if (input.Contains("@") && (input.Contains(".com") || input.Contains(".hr"))) return true;
            else return false;
        }

        public static bool IsNotNull(object test)
        {
            if (test != null) return true;
            else return false;
        }

        public static bool IsNotEmpty(string input)
        {
            return input != "" ? true : false;
        }

        public static bool IsOIBValid(string number)
        {
            IsInputNumber(number);
            if (number.Length != 11) return false;
            else return true;
        }

        public static bool IsPhoneNumberValid(string phone)
        {
            IsInputNumber(phone);
            if (phone.Length >= 6 && phone.Length <= 10) return true;
            else return false;
        }

        public static bool IsInputNumber(string input)
        {
            foreach (var item in input)
            {
                if (item < '0' || item > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
