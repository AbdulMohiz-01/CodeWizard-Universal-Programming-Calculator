using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    internal static class Checks
    {
        public static bool DivisbleByZero(Form1 obj)
        {
            if (obj.currentNumber == "0" && obj.currentOperation == "÷")
            {
                MessageBox.Show("You can't divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool InvalidEqualPressed(Form1 obj)
        {
            if (obj.equationLabel.Text.Length == 0)
            {
                MessageBox.Show("You can't press equal without a number or an operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
