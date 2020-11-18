// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab4-Arrays
//  Version: 1.0
//
//  Description: Implementation of question #2
//
//
// QUestionTwo.cs
//
//  Author:
//       Christian Lachapelle <lachapellec@gmail.com>
//
//  Copyright (c) 2020 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
namespace Lab4Arrays
{
    public static class QuestionTwo
    {
        /// <summary>
        /// Run the implementation to question #2
        /// </summary>
        public static void Run()
        {
            int dimOne=0, dimTwo=0;
            int[,] twoDArray;

            Console.WriteLine("\nQuestion 2\n");
            Console.WriteLine("Lets create a 2D array\n");

            // Create 2D array
            if (Helper.Helper.GetInput("Do you wish to enter your own dimentions?", null, true) == 0)
            {
                dimOne = Helper.Helper.GetInput("Enter the first dimention size", "10");
                dimTwo = Helper.Helper.GetInput("Enter the second dimention size", "10");
                twoDArray = new int[dimOne, dimTwo];
            }
            else
            {
                Console.WriteLine("Creating a 10x10 array\n");
                dimOne = 10;
                dimTwo = 10;
                twoDArray = new int[10, 10];
            }

            // Populate the array with random numbers between 1-10
            Random rng = new Random();

            for (int i = 0; i < dimOne; i++)
            {
                for (int j = 0; j < dimTwo; j++)
                {
                    twoDArray[i, j] = rng.Next(1, 10);
                }
            }

            int sum = 0;
            int max;
            Dictionary<int, int> maxMap = new Dictionary<int, int>();
            Dictionary<int, int> minMap = new Dictionary<int, int>();

            // Find the sum and the min # of a column in the array
            for (int i=0; i < dimOne; i++)
            {
                max = 0;
                for (int j=0; j < dimTwo; j++)
                {
                    sum += twoDArray[i, j];
                    if (twoDArray[i, j] > max) max = twoDArray[i, j]; // Assign new max if found
                    if (i == 0) minMap[j] = twoDArray[i, j]; // If first iter, map first min value to associated col
                    else if (minMap[j] > twoDArray[i, j]) minMap[j] = twoDArray[i, j]; // Map new min value to associated col if found
                    Console.Write(twoDArray[i, j] + "\t");
                }
                maxMap[i] = max; // Map the max value to the associated row
                Console.WriteLine();
            }
            Console.WriteLine(String.Format("\nSum: {0}",sum));
            Console.WriteLine(String.Format("\nAverage: {0}", (double)sum / (dimOne * dimTwo)));
            Console.WriteLine("\nMax of rows is:\n");

            // Print the max of each row in the array
            foreach (KeyValuePair<int, int> kvp in maxMap)
            {
                Console.WriteLine(String.Format("{0}: {1}", kvp.Key, kvp.Value));
            }

            Console.WriteLine("\nMin of columns is:\n");

            // Print the column header
            for (int i = 0; i < dimOne; i++)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();
            // Print the min of each col in the array
            foreach (var val in minMap.Values)
            {
                Console.Write(val + "\t");
            }

            if (Helper.Helper.GetInput("\nDo you wish to see the rotated 2D array?", null, true) == 0)
            {
                Console.WriteLine();
                for (int i=0; i < dimTwo; i++)
                {
                    for (int j=0; j<dimOne; j++)
                    {
                        Console.Write(twoDArray[j, i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\bInvalid response.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
