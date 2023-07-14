using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    internal static class Utils
    {
        public static (string, string, string, string) DecimalConversions(long number)
        {
            return (Convert.ToString(number, 16), number.ToString(), Convert.ToString(number, 8), Convert.ToString(number, 2));
        }

        public static long ConvertToDecimal(string number, int pow, bool isHex = false)
        {
            long decimalNumber = 0;
            int i = 0;
            int remainder;
            while (number.Length > 0)
            {
                remainder = isHex ? GetHexValue(number[number.Length - 1]) : int.Parse(number[number.Length - 1].ToString());
                number = number.Substring(0, number.Length - 1);
                decimalNumber += remainder * Convert.ToInt32(Math.Pow(pow, i));
                i++;
            }
            return decimalNumber;
        }

        public static (string, string, string, string) BinaryConversions(string number)
        {
            return (Convert.ToString(ConvertToDecimal(number, 2), 16), Convert.ToString(ConvertToDecimal(number, 2)), Convert.ToString(ConvertToDecimal(number, 2), 8), number);
        }
        public static (string, string, string, string) HexConversions(string number)
        {

            return (number, Convert.ToString(ConvertToDecimal(number, 16, true)), Convert.ToString(ConvertToDecimal(number, 16, true), 8), Convert.ToString(ConvertToDecimal(number, 16, true), 2));
        }

        public static (string, string, string, string) OctalConversions(string number)
        {
            return (Convert.ToString(ConvertToDecimal(number, 8), 16), Convert.ToString(ConvertToDecimal(number, 8)), number, Convert.ToString(ConvertToDecimal(number, 8), 2));
        }
        public static int GetHexValue(char hex)
        {
            if (hex >= '0' && hex <= '9')
            {
                return hex - '0';
            }
            else if (hex >= 'A' && hex <= 'F')
            {
                return hex - 'A' + 10;
            }
            else if (hex >= 'a' && hex <= 'f')
            {
                return hex - 'a' + 10;
            }
            else
            {
                return -1;
            }
        }
        public static (string, string, string, string) FormatConversions(string hex, string dec, string oct, string bin)
        {
            dec = string.Format("{0:N}", Convert.ToInt64(dec));
            dec = dec.Substring(0, dec.Length - 3);

            bin = bin.PadLeft(4, '0');

            for (int i = bin.Length - 4; i > 0; i -= 4)
            {
                bin = bin.Insert(i, " ");
            }
            for (int i = oct.Length - 3; i > 0; i -= 3)
            {
                oct = oct.Insert(i, " ");
            }

            return (hex.ToUpper(), dec, oct, bin);
        }
    }



}