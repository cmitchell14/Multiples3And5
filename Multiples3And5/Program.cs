using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            //*************_______________++++++++++++++++++++  INSTRUCTIONS  *************_______________+++++++================
            //Please complete the following for Coding Challenge 1:

            //Create a new, public repository and add a blank solution.Add a new Console Application project called Multiples3And5.

            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.  Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.  Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.\n\nPress any button to see the answer:");
            Console.ReadKey();
            Console.WriteLine();


            //Solution 1 ------------------------------------------------------------------
            List<int> Mutliples3And5 = new List<int>();


            Console.Title = "ARTP - Coding Challenge 1";

            for (int i = 1; i < 1000; i++)
            {

                if (i % 3 == 0)
                {
                    Mutliples3And5.Add(i);
                }
                else if (i % 5 == 0)
                {
                    Mutliples3And5.Add(i);
                }
                //else if (i % 3 == 0 && i % 5 == 0)
                //{
                //    Mutliples3And5.Remove(i);
                //}
            }
            Console.WriteLine("Solution 1:");
            Console.WriteLine(Mutliples3And5.Sum());
            Console.WriteLine();


            Console.WriteLine("Solution 2:");
            //Solution 2--------------------------------------------------------------
            int totalSum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalSum += i;
                }
            }
            Console.WriteLine(totalSum);
            Console.WriteLine();

            //Solution 3 --------------------------------------------------------------
            Console.WriteLine("Solution 3:");
            Console.WriteLine(Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum()
);
        }
    }
}
