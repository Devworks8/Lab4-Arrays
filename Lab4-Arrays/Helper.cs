// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab4-Arrays
//  Version: 1.0
//
//  Description: Helper class
//
//
// Helper.cs
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
namespace Helper
{
    public static class Helper
    {
        /// <summary>
        /// Get user input.
        /// </summary>
        /// <param name="msg">Message to display.</param>
        /// <param name="defaults">Default to display, if any.</param>
        /// <param name="question">Is it a question.</param>
        /// <param name="rng">Is it a random number.</param>
        /// <returns>User input as an integer.</returns>
        public static int GetInput(string msg, string defaults=null, bool question=false, bool rng=false)
        {
            while (true)
            {
                if (question)
                {
                    Console.Write("\n" + msg + ": ");
                    string yn = Console.ReadLine();
                    if (yn.Contains("y") || yn.Contains("Y")) return 0;
                    else return 1;
                }

                if (defaults is null)
                {
                    Console.Write("\n" + msg + ": ");
                }
                else
                {
                    Console.Write("\n"+String.Format(msg + " [{0}]: ", defaults));
                }

                int result;
                string input = Console.ReadLine();

                if (!int.TryParse(input, out result) && !String.IsNullOrEmpty(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\bERROR: Invalid value...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (String.IsNullOrEmpty(input))
                {
                    return Convert.ToInt32(defaults);
                }
                else if (result <= 0 && !rng)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\bERROR: Invalid value...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    return result;
                }
            } 
        }
    }
}
