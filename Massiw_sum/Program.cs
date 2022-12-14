using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            float s = 0;
 
            Random rnd = new Random();
 
            for (int i = 0; i < 10; i++)
            {
                A[i] = rnd.Next(1, 70);
                Console.WriteLine(A[i]);
 
                if (A[i] % 2 != 0) ;
 
                s += A[i];
               
            }
 
            Console.WriteLine("s={0}", s);
            Console.ReadKey();
        }
    }
}