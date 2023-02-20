using System;
using System.Globalization;

namespace Course {
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferência = " + Circunferencia(raio).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + Volume(raio).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi);

        }

        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}