using System;
using System.Security.Cryptography;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input 
            int n = int.Parse(Console.ReadLine());

            // Calculations
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;


            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (currNumber < 200)        p1++;
                else if (currNumber < 400)   p2++;   
                else if (currNumber < 600)   p3++;    
                else if (currNumber < 800)   p4++;
                else                         p5++;
            }

            // Output
            Console.WriteLine($"{(double)p1 / n * 100:f2}%");
            Console.WriteLine($"{(double)p2 / n * 100:f2}%");
            Console.WriteLine($"{(double)p3 / n * 100:f2}%");
            Console.WriteLine($"{(double)p4 / n * 100:f2}%");
            Console.WriteLine($"{(double)p5 / n * 100:f2}%");










        }
    }
}
