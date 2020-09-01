using System;

namespace ConvertirDeMillasAKilometros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte la cantidad de millas que desea convertir a Kilometros: ");
           string valor1 = Console.ReadLine();

            int millas1 = Convert.ToInt32(valor1);
            double akilometros = millas1 * 1.609;

            Console.WriteLine("{0} Millas = a {1} Kilometros", millas1, akilometros);

        }
    }
}
