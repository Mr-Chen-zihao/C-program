using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please input a number:");
            num = Console.Read();
            Console.WriteLine("Its prime factor is:");
            int i = 2;
            while (i * i < num) 
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
                else
                {
                    i++;
                }
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
