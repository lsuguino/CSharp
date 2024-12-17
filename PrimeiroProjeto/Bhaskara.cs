using System;
using System.Globalization;

namespace Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta == 0)
            {
                Console.WriteLine("Impossível de ser calculado, o valor de A e Delta não podem ser ZERO");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("O valor de x1 é " + x1.ToString("F5"), CultureInfo.InvariantCulture);
                Console.WriteLine("O valor de x2 é " + x2.ToString("F5"), CultureInfo.InvariantCulture);
            }
            Console.ReadLine();
        }
    }
}
