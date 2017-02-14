using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangaloreBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, length, minimalTime = 0;
            int[] accountNumber = new int[10000];
            Console.WriteLine("Enter the length of the bank number:");
            length= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bank account number:");
            for(i=0;i<length;i++)
            {
                accountNumber[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The bank account number is:");
            for (i = 0; i < length; i++)
            {
                Console.Write(accountNumber[i]);
                if(accountNumber[i]==0)
                {
                    accountNumber[i] = 10;
                }
            }
            int leftIndex = accountNumber[1];
            int rightIndex = accountNumber[0];
            int j;
            Console.Write("\n");
            for (i=0;i<length;i++)
            { 
                if((Math.Abs(accountNumber[i]-rightIndex))<Math.Abs((accountNumber[i]-leftIndex)))
                {
                    minimalTime = minimalTime + Math.Abs(accountNumber[i] -rightIndex)+1;
                    rightIndex = accountNumber[i];
                }
                else
                {
                    minimalTime = minimalTime + Math.Abs(accountNumber[i] -leftIndex)+1;
                    leftIndex = accountNumber[i];
                }
                
            }
            Console.WriteLine("The minimum time taken by the user is :"+minimalTime);
            Console.Read();
        }
    }
}
