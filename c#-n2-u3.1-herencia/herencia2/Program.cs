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
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();

            Vehiculo v2 = new Camioneta();
            // NOTA: la siguiente línea queda intencionalmente con un error de compilación (CS0029)
            // en el estado final mostrado en el video: no se puede convertir implícitamente
            // 'herencia2.Auto' a 'herencia2.Camioneta'. El presentador lo deja así a propósito
            // para mostrar qué conversiones NO son válidas entre clases hermanas de una jerarquía.
            Camioneta c2 = new Auto();
        }
    }
}
