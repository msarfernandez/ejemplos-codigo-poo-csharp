using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    // INFERIDO: no se vio en pantalla la clase base exacta de Pez. Se infiere "AnimalSalvaje"
    // por tratarse de un animal no doméstico y porque, al no sobreescribir comunicarse(),
    // en la ejecución final imprime el mismo "ruido... ruido..." que la clase base Animal.
    class Pez : AnimalSalvaje
    {
    }
}
