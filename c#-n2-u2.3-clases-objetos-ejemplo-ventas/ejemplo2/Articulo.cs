using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Articulo
    {
        //- Código Artículo (3 dígitos no correlativos)
        //- Precio
        //- Código de Marca (1 a 10)
        //private int codArticulo;
        public int CodigoArticulo { get; set; }
        //private float precio;
        public float Precio { get; set; }
        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
