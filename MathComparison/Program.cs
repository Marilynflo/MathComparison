using System;

namespace MathComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1:");
            Console.WriteLine("Hourly Rate: $15");
            Console.WriteLine("Hours worked:40");
            int rate = 15;
            int hours = 40;
            int total = 15 * 40;
            int combined = total * 52;
            Console.WriteLine("The annual salary for person 1: " + combined);

            Console.WriteLine("Person2:");
            Console.WriteLine("Hourly Rate: $20");
            Console.WriteLine("Hours worked:40");
            int rate2 = 20;
            int hours2 = 40;
            int total2 = 20 * 40;
            int combined2 = total2 * 52;
            Console.WriteLine("The annual salary for person 1: " + combined2);

            int person1 = 31200;
            int person2 = 41600;

            bool isHigher = person1  > person2;
            Console.WriteLine("Person1 makes more money than Person2");
            Console.WriteLine(isHigher);
            Console.ReadLine();
         

        }
    }
}
