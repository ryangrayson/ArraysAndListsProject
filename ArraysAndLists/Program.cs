using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10 -DONE

            var myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds" -DONE
             */

            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */



            for (int i = 2; i <= 40; i += 2)
            {
                evens.Add(i);
              
            }
            foreach (var evenNum in evens)
            {
                Console.WriteLine(evenNum);
            }



            for (int i = 1; i <= 39; i += 2)
            {
                odds.Add(i);
            }
            foreach (var oddNum in odds)
            {
                Console.WriteLine(oddNum);
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

        }
    }
}
