using System;
 
using System.Collections.Generic;
 
using System.Linq;
 
using System.Text;
 
 
 
namespace check1
 
{
 
    class Program
 
    {
 
        static void Main(string[] args)
 
        {
 
            int i;
 
            Console.Write("Введите число : ");
 
            i = int.Parse(Console.ReadLine());
 
            if (i % 2 == 0)
 
            {
 
                Console.Write("Введенное число является четным");
 
                Console.Read();
 
            }
 
            else
 
            {
 
                Console.Write("Введенное число нечетное");
 
                Console.Read();
 
            }
 
        }
 
    }
 
}