using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of a triangle.");
            
            double[] sides = new double[3];
            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write($"Length of side {i+1}: ");
                sides[i] = double.Parse(Console.ReadLine());
            }

            double area = GetArea(sides[0], sides[1], sides[2]);
            Console.WriteLine($"Area = {Math.Round(area, 2)}");  

            Console.ReadKey();
        }


        static double GetArea(double a, double b, double c)
        {
            double s = (a + b + c ) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area; 
        }
    }
}
