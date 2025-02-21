﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class LineCompare
    {
        static void Main(string[] args)
        {
            // UC-3: To compare the lengths of the two lines

            // Taking inputs for line 1
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Taking inputs for line 2
            Console.Write("Enter p1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter q1: ");
            double q1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter p2: ");
            double p2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter q2: ");
            double q2 = Convert.ToDouble(Console.ReadLine());

            // Calculating the line lengths
            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double length2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            
            // Displaying line lengths
            Console.WriteLine("Length of the line1 = {0} units", length1);
            Console.WriteLine("Length of the line2 = {0} units", length2);

            // Comparing the line lengths
            if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Length of line1 is more than the length of line2");
            }
            else if (length2.CompareTo(length1) > 0)
            {
                Console.WriteLine("Length of line2 is more than the length of line 1");
            }
            else
            {
                Console.WriteLine("Lengths of both the lines are equal");
            }
            Console.ReadLine();
        }
    }
}
