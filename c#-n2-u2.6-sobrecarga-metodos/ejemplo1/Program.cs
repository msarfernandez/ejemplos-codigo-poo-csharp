using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            Persona p1 = new Persona("PEPE");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("MAXI"));
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plástico");
            //b1.Capacidad = 200;

            //Botella b2 = new Botella();

            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);

            //float valor = 1.2333333F;
            //Console.WriteLine(valor.ToString());

            //int algo = b1.Capacidad;

            Console.ReadKey();
        }
    }
}
