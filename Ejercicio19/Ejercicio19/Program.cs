using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Debe ingresar un número. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }

            Console.Write($"La parte entera de {num1} es {Math.Floor(num1)}");
            Console.ReadKey();
        }
    }
}
