using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;

        //PROPIEDAD
        public int Capacidad
        {
            get
            {
                return capacidad;
            }
            set
            {
                capacidad = value;
            }
        }
    }
}
