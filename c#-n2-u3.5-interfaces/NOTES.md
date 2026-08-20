# c#-n2-u3.5-interfaces — Reconstrucción del proyecto del video

## A. Resumen del proyecto

Este video continúa con el proyecto **`herencia3`** (del video anterior) de la solución `POO1`.
Desarrolla sobre la jerarquía de animales existente para introducir el concepto de **interfaces**
con la interfaz `Flyable` (volador), que es implementada por las clases `Canario` y `Aguila`.

Puntos clave mostrados en el video:

- Se crea una nueva **interfaz `Flyable`** que define el método `string volar()` sin implementación.
- `Canario` (que hereda de `AnimalDomestico`) implementa `Flyable` y proporciona su implementación
  del método `volar()` → `"vuela como un canario..."`.
- `Aguila` (que hereda de `AnimalSalvaje`) también implementa `Flyable` con su propia
  implementación → `"vuela como un águila..."`.
- Se crea un `List<Flyable>` llamado `listaVoladores` que almacena objetos que implementan
  la interfaz `Flyable` (polimorfismo mediante interfaces).
- Se agrega instancias de `Canario` y `Aguila` a `listaVoladores`.
- Se recorre `listaVoladores` con un `foreach` que llama a `item.volar()` en cada elemento,
  demostrando que cada objeto ejecuta su propia versión del método (polimorfismo).
- Se mantiene la lista de animales original (`List<Animal>`) que continúa funcionando con
  el método `comunicarse()`, ahora ejecutándose junto con la nueva funcionalidad de voladores.

## B. Estructura de archivos

```text
c#-n2-u3.5-interfaces/
└── herencia3/
    ├── herencia3.csproj
    ├── Animal.cs
    ├── AnimalDomestico.cs
    ├── AnimalSalvaje.cs
    ├── Gato.cs
    ├── Perro.cs
    ├── Canario.cs       (NEW: implementa Flyable)
    ├── Aguila.cs        (NEW: implementa Flyable)
    ├── Pez.cs
    ├── Tigre.cs
    ├── Flyable.cs       (NEW: interfaz)
    └── Program.cs
```

## C. Código

**Ruta:** `herencia3/Flyable.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    interface Flyable
    {
        string volar();
    }
}
```

**Ruta:** `herencia3/Canario.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Canario : AnimalDomestico, Flyable
    {
        public string volar()
        {
            return "vuela como un canario...";
        }
    }
}
```

**Ruta:** `herencia3/Aguila.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Aguila : AnimalSalvaje, Flyable
    {
        public string volar()
        {
            return "vuela como un águila...";
        }
    }
}
```

**Ruta:** `herencia3/Program.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "PEPE";

            Perro p1 = new Perro();
            p1.Nombre = "Negrito";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            Console.WriteLine("\n");

            foreach (Flyable item in listaVoladores)
            {
                Console.WriteLine(item.volar());
            }

            Console.ReadKey();
        }
    }
}
```

**Ruta:** `herencia3/Animal.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Animal
    {
        public virtual string comunicarse()
        {
            return "ruido... ruido...";
        }
    }
}
```

**Ruta:** `herencia3/AnimalDomestico.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return "Animal Doméstico: " + Nombre;
        }
    }
}
```

**Ruta:** `herencia3/AnimalSalvaje.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class AnimalSalvaje : Animal
    {
    }
}
```

**Ruta:** `herencia3/Gato.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Gato : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "miau miau....";
        }
    }
}
```

**Ruta:** `herencia3/Perro.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Perro : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "Guau guau....";
        }
    }
}
```

**Ruta:** `herencia3/Pez.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Pez : AnimalSalvaje
    {
    }
}
```

**Ruta:** `herencia3/Tigre.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    class Tigre : AnimalSalvaje
    {
    }
}
```

## D. Dependencias y configuración

- Consola de .NET, sin paquetes NuGet, mismo estilo que los proyectos de los
  videos anteriores de esta unidad.
- `<TargetFramework>net9.0</TargetFramework>`
- Comandos:
  ```
  cd herencia3
  dotnet run
  ```

## E. Salida esperada del programa

Basándose en el flujo lógico del código:

```
Guau guau....
ruido... ruido...
ruido... ruido...
vuela como un canario...
ruido... ruido...
miau miau....

vuela como un canario...
vuela como un águila...
```

## F. Elementos inferidos

Ninguno. Todos los elementos del código fueron claramente visibles en el video o
son derivaciones lógicas directas del patrón mostrado.

## G. Conceptos clave enseñados

1. **Interfaces**: Contrato que define qué métodos deben implementar las clases.
2. **Implementación múltiple**: Una clase puede heredar de una clase base e implementar
   una interfaz simultáneamente.
3. **Polimorfismo mediante interfaces**: `List<Flyable>` puede contener cualquier objeto
   que implemente `Flyable`, permitiendo llamar a `volar()` de manera polimórfica.
4. **Diferencia entre herencia e interfaces**: Las interfaces no aportan implementación,
   solo definen el contrato que las clases deben cumplir.
