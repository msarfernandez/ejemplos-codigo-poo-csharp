using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        //Métodos
        public string saludar()
        {
            return "Hola soy... " + nombre;
        }

        //sobrecarga de saludar()
        public string saludar(string personaje)
        {
            return "Hola " + personaje + ", soy... " + nombre;
        }
    }
}
