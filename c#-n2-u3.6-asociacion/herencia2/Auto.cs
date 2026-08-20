using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    class Auto : Vehiculo
    {
        public Auto()
        {
        }

        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //Composición
        public Chasis Chasis { get; set; }

        //Agregación
        public Motor Motor { get; set; }
    }
}
