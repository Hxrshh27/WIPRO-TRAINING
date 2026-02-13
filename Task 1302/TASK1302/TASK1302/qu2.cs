// Given a sentence s, determine whether it is a palindrome sentence or not. A palindrome sentence is a sequence of characters that reads the same forward and backward after:

// Converting all uppercase letters to lowercase.
// Removing all non-alphanumeric characters (i.e., ignore spaces, punctuation, and symbols).
// Examples: 

// Input: s = "Too hot to hoot."
// Output: true
// Explanation: If we remove all non-alphanumeric characters and convert all uppercase letters to lowercase, string s will become "toohottohoot" which is a palindrome.
// Input: s = "Abc 012..##  10cbA"
// Output: true
// Explanation: If we remove all non-alphanumeric characters and convert all uppercase letters to lowercase, string s will become "abc01210cba" which is a palindrome.
// Input: s = "ABC $. def01ASDF.."
// Output: false
// Explanation: If we remove all non-alphanumeric characters and convert all uppercase letters to lowercase, string s will become "abcdef01asdf" which is not a palindrome.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1302
{
    internal class qu2
    {
        static void Main()
        {
            Console.WriteLine("Input : ");
            string s = Console.ReadLine();

            char[] arr = new char[s.Length];
            int k = 0;
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c >= 'A' && c<= 'Z')
                {
                    arr[k++] = (char)(c + 32);
                }
                else if(( c>= 'a' &&  c<='z') ||  ( c>= '0' && c<='9' ))
                {
                    arr[k++] = c;
                }
            }
            bool isPalindrome = true;
            for(int i=0;i < k/2 ;i++)
            {
                if(arr[i] != arr[k-1-i])
                {
                    isPalindrome = false;
                    break; 
                }
            }
            Console.WriteLine("Output : " + (isPalindrome ? "true" : "false"));
        }
    }
}
