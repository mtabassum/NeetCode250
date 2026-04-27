using System;
using System.Collections.Generic;
using System.Text;

namespace TwoPointers.ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            char temp = '\0';
            int n = s.Length;

            for (int i = 0; i < n / 2; i++)
            {
                temp = s[i];
                s[i] = s[n - 1 - i];
                s[n - 1 - i] = temp;
            }
        }
    }
}

