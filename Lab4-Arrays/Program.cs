// Name: Christian Lachapelle
//  Student #: A00230066
//
//  Title: Lab4-Arrays
//  Version: 1.0
//
//  Description: Lab 4 - Arrays Assignment
//
//
// Program.cs
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

namespace Lab4Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            QuestionOne.Run();
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey(true);
            QuestionTwo.Run();
            Console.WriteLine("\nThank you for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
