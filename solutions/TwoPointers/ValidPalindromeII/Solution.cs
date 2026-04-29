using System;
using System.Collections.Generic;
using System.Text;

namespace TwoPointers.ValidPalindromeII
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while(left < right)
            {
                if (s[left] != s[right])
                {
                    string skipLeft = s.Substring(left+1, right-left);
                    string skipRight = s.Substring(left, right - left);
                    return IsPalindrome(skipLeft) || IsPalindrome(skipRight);
                }
                left++;
                right--;
            }
            return true;
         }

        public bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
