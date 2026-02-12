using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfParctise
{
    internal class que
    {
        public que()
        {
            Console.WriteLine("WHAT IS LINE");
            string sent = Console.ReadLine();
            string[] words = sent.Split();
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                string rev = "";

                for (int j = word.Length - 1; j >= 0; j--)  
                {
                    rev = rev + word[j];
                }

                if (word == rev)
                {
                    count++;
                    Console.Write(count);
                }
            }
        }
    }
}
