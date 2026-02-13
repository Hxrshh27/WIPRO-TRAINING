using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1302
{
    internal class qu3
    {
        static void Main()
        {
            Console.WriteLine("Enter K : ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter String : ");
            string s = Console.ReadLine();

            bool changed = true;

            while (changed)
            {
                changed = false;
                string result = "";

                for (int i = 0; i < s.Length; i++)
                {
                    int count = 1;

                    while (i + 1 < s.Length && s[i] == s[i + 1])
                    {
                        count++;
                        i++;
                    }

                    if (count != k)
                    {
                        for (int j = 0; j < count; j++)
                        {
                            result += s[i];
                        }
                    }
                    else
                    {
                        changed = true; 
                    }
                }

                s = result;
            }

            Console.WriteLine("Output : " + s);
        }
    }
}

