using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedFunction
{
    class A
    {
        public int Func(int a)
        {
            a = a * 2;
            return (a);
        }
    }
    class B
    {
        public int Func(int a)
        {
            a = a * 3;
            return(a);
        }
    }
    class C
    {
       public  int Func(int a)
        {
            a = a * 5;
            return (a);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            int callA = 0, callB = 0, callC = 0;
            Console.WriteLine("Enter a value");
            int finalValue = int.Parse(Console.ReadLine());
            int initialValue = 1;
            A obj = new A();
            B obj1 = new B();
            C obj2 = new C();
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
                    obj1.Func(initialValue);
                    finalValue = finalValue / 3;

                }
                else if (finalValue % 5 == 0)
                {
                    callC++;
                    obj2.Func(initialValue);
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
