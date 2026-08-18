using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Maxi";

            nombre = "hola cómo estás ???? " + nombre;

            int cant = nombre.Length;

            nombre = nombre.Replace("hola", "chau");

            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
