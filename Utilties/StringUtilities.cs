using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsSimpleSupportRequest.Utilties
{
    public static class StringUtilities
    {
        public static int CountChars(string value)
        {
            int result = 0;
            bool lastValueWasSpace = false;

            foreach(char c in value)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (!lastValueWasSpace)
                    {
                        result++;
                    }
                    lastValueWasSpace = true;
                }
                else
                {
                    result++;
                    lastValueWasSpace = false;
                }
            }

            return result;
        }
    }
}
