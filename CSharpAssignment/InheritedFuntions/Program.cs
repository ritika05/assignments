using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedFunction
{
    class MultiplicationOfTwo
    {
        public int Func(int a)
        {
            a = a * 2;
            return (a);
        }
    }
    class MultiplicationOfThree :MultiplicationOfTwo
    {
        public int Func1(int a)
        {
            a = a * 3;
            return(a);
        }
    }
    class MultiplicationOfFive :MultiplicationOfThree
    {
       public  int Func2(int a)
        {
            a = a * 5;
            return (a);
        }
    }
    class Program :MultiplicationOfFive
    {
        
        static void Main(string[] args)
        {
            int callA = 0, callB = 0, callC = 0;
            Console.WriteLine("Enter a value");
            int finalValue = int.Parse(Console.ReadLine());
            int initialValue = 1;
            Program obj = new Program();
            while(initialValue!=finalValue)
            {
                if (finalValue % 2 == 0)
                {
                    callA++;
                    obj.Func(initialValue);
                    finalValue = finalValue / 2;

                }
                else if (finalValue % 3 == 0)
                {
                    callB++;
                    obj.Func1(initialValue);
                    finalValue = finalValue / 3;

                }
                else if (finalValue % 5 == 0)
                {
                    callC++;
                    obj.Func2(initialValue);
                    finalValue = finalValue / 5;
                }
                else
                {
                    Console.WriteLine("error");
                    break;
                }
            }
           
            Console.WriteLine("A is called="+callA);
            Console.WriteLine("B is called="+callB);
            Console.WriteLine("C is called="+callC);
            Console.Read();
        }
    }
}
