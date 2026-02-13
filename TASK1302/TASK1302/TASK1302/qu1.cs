// { 1) First non-repeating character of given string Given a string s of lowercase English letters, the task is to find the first non-repeating character. If there is no such character, return '$'.

// Examples: Input: s = "geeksforgeeks"
// Output: 'f'
// Explanation: 'f' is the first character in the string which does not repeat.

// Input: s = "racecar"
// Output: 'e'
// Explanation: 'e' is the only character in the string which does not repeat.

// Input: "aabbccc"
// Output: '$'
// Explanation: All the characters in the given string are repeating.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1302
{
    class que1
    {
        static void Main()
        {
            Console.WriteLine("Input s = ");
            string s = Console.ReadLine();

            bool[] repeat = new bool[s.Length];
            for(int i=0; i < s.Length; i++)
            {
                for(int j=0; j < s.Length; j++)
                {
                    if (i != j && s[i] == s[j])
                    {
                        repeat[i] = true; 
                        break; 
                    }
                }
            }
            char ans = '$';
            for(int i=0;i<s.Length; i++)
            {
                if(repeat[i] == false)
                {
                    ans = s[i];
                    break;
                }
            }
            Console.WriteLine("Output : "+ans);
       



        }
    }
}
