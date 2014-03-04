using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hrbu.Teaching.Utility
{
    public class PasswordMgr
    {
        private static string numbers = "0123456789";

        private static string lowerChars = "abcdefghijklmnopqrstuvwxyz";

        private static string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string otherChars = "!@#$%-+?";

        public static string CreateRandomPw(int length, bool containNum,
            bool containLowerChars, bool containUpperChars, bool containOtherChars)
        {
            if (length < 6)
            {
                throw new ArgumentException("length必须大于6");
            }
            
            StringBuilder sb = new StringBuilder();

            Random rand = new Random();

            string charSet = string.Empty;

            sb.Append(lowerChars[rand.Next(0, lowerChars.Length)]);

            sb.Append(upperChars[rand.Next(0, upperChars.Length)]);

            sb.Append(numbers[rand.Next(0, numbers.Length)]);

            if (containNum)
            {
                charSet += numbers;
            }
            if (containLowerChars)
            {
                charSet += lowerChars;
            }
            if (containUpperChars)
            {
                charSet += upperChars;
            }
            if (containOtherChars)
            {
                charSet += otherChars;
            }

            for (int i = 3; i < length; i++)
            {
                int num = rand.Next(0, charSet.Length);

                sb.Append(charSet[num]);
            }

            return sb.ToString();
        }
    }
}
