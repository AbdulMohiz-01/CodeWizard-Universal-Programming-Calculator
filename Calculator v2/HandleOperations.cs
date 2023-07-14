using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v2
{
    internal static class HandleOperations
    {
        public static void Decimal(string currentOperation, string previousNumber, string currentNumber, ref string result)
        {
            result = DoCalculation(Convert.ToInt64(currentNumber), Convert.ToInt64(previousNumber), currentOperation).ToString();
        }
        public static void Hexadecimal(string currentOperation, string previousNumber, string currentNumber, ref string result)
        {
            result = DoCalculation(Convert.ToInt64(currentNumber, 16), Convert.ToInt64(previousNumber, 16), currentOperation).ToString("X");
        }
        public static void Binary(string currentOperation, string previousNumber, string currentNumber, ref string result)
        {
            result = Convert.ToString(DoCalculation(Convert.ToInt64(currentNumber, 2), Convert.ToInt64(previousNumber, 2), currentOperation), 2);
        }

        public static void Octal(string currentOperation, string previousNumber, string currentNumber, ref string result)
        {
            result = Convert.ToString(DoCalculation(Convert.ToInt64(currentNumber, 8), Convert.ToInt64(previousNumber, 8), currentOperation), 8);
        }
        private static long DoCalculation(long currentNumber, long previousNumber, string currentOperation)
        {
            if (currentOperation == "+")
            {
                return previousNumber + currentNumber;
            }
            else if (currentOperation == "-")
            {
                return previousNumber - currentNumber;
            }
            else if (currentOperation == "x")
            {
                return previousNumber * currentNumber;
            }
            else if (currentOperation == "÷")
            {
                return previousNumber / currentNumber;
            }
            else if (currentOperation == "%")
            {
                return previousNumber % currentNumber;
            }
            else if (currentOperation == "AND")
            {
                return previousNumber & currentNumber;
            }
            else if (currentOperation == "OR")
            {
                return previousNumber | currentNumber;
            }
            else if (currentOperation == "XOR")
            {
                return previousNumber ^ currentNumber;
            }
            else if (currentOperation == "NAND")
            {
                return ~(previousNumber & currentNumber);
            }
            else if (currentOperation == "NOR")
            {
                return ~(previousNumber | currentNumber);
            }
            else
            {
                return 0;
            }
        }
    }
}
