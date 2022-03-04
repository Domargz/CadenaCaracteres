using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            //Preguntamos el nombre del usuario
            Console.WriteLine("Como te llamas: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " Quieres el menu?");
            Console.ReadKey();
        }
    }
}
