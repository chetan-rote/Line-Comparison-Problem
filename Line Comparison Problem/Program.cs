/******************************************************************************
 *  Execution:    Line Comparison Problem.exe
 *  
 *  Purpose: Line comparison using their coordinates points.
 *
 *  @author  Chetan
 *  @version 1.0
 *  @since   2020
 *
 ******************************************************************************/

using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Length of the line P1P2 is : " + ComputeLength());
        }
        /// <summary>
        /// Lengthes the of line.
        /// </summary>
        /// <returns></returns>
        static double ComputeLength()
        {
            //Reads coordinates of point 1.
            Console.WriteLine("Enter the X & Y coordinates of P1");
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());

            //Reads coordinates of point 2.
            Console.WriteLine("Enter the X & Y coordinates of P2");
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            //Formula to calculates length of lines.
            double length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return length;
        }
    }
}
