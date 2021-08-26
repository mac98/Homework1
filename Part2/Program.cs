/// Chapter No. 1		Exercise No. 2
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  August 26, 2021
///
/// Problem Statement: Display a picture or shape using WriteLine commands.
/// 
/// Overall Plan:
/// 1) Use WriteLines to create image of a question mark block.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //The WriteLines for the image

            Console.WriteLine("  ____________");
            Console.WriteLine(" /           /|");
            Console.WriteLine("/___________/ |");
            Console.WriteLine("|+    _    +| |");
            Console.WriteLine("|    / \\    | |");
            Console.WriteLine("|      /    | |");
            Console.WriteLine("|     |     | |");
            Console.WriteLine("|     .     | /");
            Console.WriteLine("|+_________+|/");
            Console.ReadLine();
        }
    }
}
