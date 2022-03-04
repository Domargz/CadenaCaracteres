using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int num1 = 5;
            int num2, resultado;

            //Preguntamos al usuario el numero
            Console.Write("Dame un numero para sumarlo: ");
            //Se asigna la variable de tipo string
            cadena = Console.ReadLine();
            //num2 = Convert.ToInt32(cadena);
            
            //Parse al recibir valor nulo crea una excepcion
            num2 = Int32.Parse(cadena);
            //Realizar la suma
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
