using System;
using System.Globalization;

namespace Course {
    class Program {


        static void Main(string[] args) {
            Calculadora calc = new Calculadora();


            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferência = " + calc.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume = " + calc.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi);

        }


    }
}