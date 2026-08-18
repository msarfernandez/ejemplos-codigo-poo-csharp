using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        // sobrecargar el constructor
        public Botella()
        {

        }
        ~Botella()
        {
            // la logica...
        }
        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;

        public string Material
        {
            get { return material; }
        }

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
