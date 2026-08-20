using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona > Lider > Developer > Tester > Automovil
            //Computadora >> AireAcondicionado
            Persona p1 = new Persona();
            Developer d1 = new Developer();

            Lider.algo();

            Console.WriteLine("hola");
        }
    }
}
