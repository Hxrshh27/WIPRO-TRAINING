using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfParctise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE SENTENCE :");
            string sent = Console.ReadLine();
            string[] words = sent.Split();
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 1)
                {
                    string rev = "";
                    for (int j = words[i].Length - 1; j >= 0; j--)
                    {
                        rev = rev + words[i][j];
                    }
                    Console.Write(rev + " ");
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        
    }
    }
}
