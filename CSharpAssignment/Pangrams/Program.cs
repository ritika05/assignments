using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter a String :");
            string sentence = Console.ReadLine();
            sentence = sentence.ToUpper();
            if(sentence.Length<26)
            {
                Console.WriteLine("not pangram");

            }
            else
            {

                for (int j = 65; j < 91; j++)
                {
                    for (int i = 0; i < sentence.Length; i++)
                    {

                        if (sentence.ElementAt(i) == j)
                        {
                            flag++;
                            break;

                        }

                    }

                }
                if (flag == 26)
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.WriteLine("not pangram");
                }
            }
            Console.ReadLine();
        }
    }
}
