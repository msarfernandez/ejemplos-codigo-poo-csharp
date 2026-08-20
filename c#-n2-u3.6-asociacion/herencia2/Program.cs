using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Camioneta c1 = new Camioneta();
            c1.Color = "Roja";
            c1.Capacidad = 500;

            Camioneta c2 = new Camioneta();
            c2.Color = "Azul";
            c2.Capacidad = 750;

            Camioneta c3 = new Camioneta();
            c3.Color = "Amarilla";
            c3.Capacidad = 1000;

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            ////listaCamionetas[1].Color = "Negra";
            //c2.Color = "Verde";
            //Console.WriteLine("El color es: " + listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine("Color: " + item.Color);
            //}

            Auto a1 = new Auto();

            a1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
