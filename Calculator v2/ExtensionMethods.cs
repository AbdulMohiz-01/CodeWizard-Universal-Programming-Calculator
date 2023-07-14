using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    internal static class ExtensionMethods
    {

        public static string DoFormatting(this string text, string currentSelectedConversion)
        {
            if (currentSelectedConversion == "DEC")
            {
                if (text.Length > 3)
                {
                    text = UndoFormatting(text, "DEC");
                    for (int i = text.Length - 3; i > 0; i -= 3)
                    {
                        text = text.Insert(i, ",");
                    }
                }
            }
            else if (currentSelectedConversion == "OCT")
            {
                if (text.Length > 3)
                {
                    text = UndoFormatting(text, "OCT");
                    for (int i = text.Length - 3; i > 0; i -= 3)
                    {
                        text = text.Insert(i, " ");
                    }
                }
            }
            else if (currentSelectedConversion == "BIN")
            {
                text = UndoFormatting(text, "BIN");
                for (int i = text.Length - 4; i > 0; i -= 4)
                {
                    text = text.Insert(i, " ");
                }
            }
            return text;
        }

        public static string UndoFormatting(this string text, string currentSelectedConversion)
        {
            if (currentSelectedConversion == "DEC")
            {
                return text.Replace(",", "");
            }
            else if (currentSelectedConversion == "OCT")
            {
                return text.Replace(" ", "");
            }
            else if (currentSelectedConversion == "BIN")
            {
                return text.Replace(" ", "");
            }
            else
            {
                return text;
            }
        }
    }
}
