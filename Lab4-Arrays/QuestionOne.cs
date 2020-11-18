// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab4-Arrays
//  Version: 1.0
//
//  Description: Implementation of question #1
//
//
// QuestionOne.cs
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
using System.Linq;
using System.Collections.Generic;
namespace Lab4Arrays
{
    public static class QuestionOne
    {
        /// <summary>
        /// Run the implementation to question #1
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Question 1");

            // Create the array
            int[] array = new int[Helper.Helper.GetInput("Enter size of array", "10")];

            if (Helper.Helper.GetInput("Do you wish to randomize the entries?",null, true) == 0)
            {
                int low = Helper.Helper.GetInput("Enter low limit", "1", false, true);
                int high = Helper.Helper.GetInput("Enter high limit", "100", false, true);
                Random rng = new Random();

                for (int i=0; i < array.Length; i++)
                {
                    array[i] = rng.Next(low, high);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\bInvalid response.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Asking for input.\n");

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Helper.Helper.GetInput("Enter a number");
                }
            }

            // Print the values of the array
            Console.WriteLine("\nValues");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }

            // Print the values of the array in reverse
            Console.WriteLine("\nReverse");
            for (int i=0; i < array.Length; i++)
            {
                Console.Write(array[array.Length - 1 - i] + "\t");
            }

            // Print Even values in array
            Console.WriteLine("\nEven Values");
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) Console.Write(array[i] + "\t");
            }

            // Print Odd index values
            Console.WriteLine("\nOdd Indexes");
            for (int i=1; i < array.Length; i += 2)
            {
                Console.Write(array[i] + "\t");
            }

            // Ask user if they want to display more information about a number
            if (Helper.Helper.GetInput("\nDo you wish to know more about a number in the array", null, true) == 0)
            {
                int num = Helper.Helper.GetInput("Enter the number");
                if (array.Contains(num))
                {
                    int count = 0;
                    int idx = 0;
                    bool notFound = true;
                    Dictionary<int, int> popular = new Dictionary<int, int>();

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == num)
                        {
                            if (notFound)
                            {
                                idx = i;
                                notFound = false;
                            }
                            count++;
                        }

                        // Keep track of occurences
                        if (popular.ContainsKey(array[i]))
                        {
                            popular[array[i]] += 1;
                        }
                        else popular[array[i]] = 1;
                    }
                    Console.WriteLine("\nThis is what I found...\n");
                    Console.WriteLine(String.Format("{0} occurs {1} time(s).", num, count));
                    Console.WriteLine(String.Format("The first occurence of {0} can be found at index {1} of the array.", num, idx));

                    int famous = 0;
                    int max = 0;
                    // Find the most popular number
                    foreach (KeyValuePair<int, int> kvp in popular)
                    {
                        if (kvp.Value > max)
                        {
                            famous = kvp.Key;
                            max = kvp.Value;
                        }
                    }
                    Console.WriteLine(String.Format("The number that appears the most is {0}", famous));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Value not found in the array.");
                    Console.ForegroundColor = ConsoleColor.White;
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
