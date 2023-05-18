using System;

namespace P07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                num1 = num1 * num1;
                Console.WriteLine($"{num1:f3}");
            }
            else if (type == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double s = num1 * num2;
                Console.WriteLine($"{s:f3}");
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double s = Math.PI * radius * radius;
                Console.WriteLine($"{s:f3}");
            }
            else if (type == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double s = num1 * num2 / 2;
                Console.WriteLine($"{s:f3}");
            }
        }
    }
}
