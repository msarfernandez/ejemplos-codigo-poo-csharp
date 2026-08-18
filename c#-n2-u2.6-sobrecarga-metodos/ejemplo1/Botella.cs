using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        //capacidad máxima: 100
        //cantidadActual: inicia en cero.
        //método recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100.
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //sobrecargar el constructor
        public Botella() { }

        ~Botella()
        {
            //la logica...
        }

        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material; }
        }

        //Métodos
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        //sobrecarga de recargar()
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            //100 50
            //cant X=??
        }
    }
}
