# c#-n2-u3.6-asociacion — Reconstrucción del proyecto del video

## A. Resumen del proyecto

Este video introduce un **nuevo proyecto `herencia2`** en la solución `POO1`, el cual desarrolla
el concepto de **asociación entre clases** mediante **composición** y **agregación**.

El proyecto demuestra dos formas de relacionar objetos:

1. **Composición**: Una relación "es parte de" donde un objeto contiene otro y es responsable
   de su ciclo de vida.
2. **Agregación**: Una relación más débil donde un objeto contiene otro pero no es responsable
   de su existencia.

Puntos clave mostrados en el video:

- Se crea una clase base `Vehiculo` vacía.
- Se define una clase `Auto` que hereda de `Vehiculo` con propiedades básicas (`Anio`, `Modelo`, `Color`).
- Se crea una clase `Chasis` con propiedad `Tipo`.
- Se crea una clase `Motor` con propiedades `Potencia` y `Tipo`.
- Dentro de `Auto`:
  - **Composición**: `public Chasis Chasis` (el chasis es parte integral del auto)
  - **Agregación**: `public Motor Motor` (el motor puede ser intercambiable, no es parte integral)
- Se define una clase `Camioneta` que también hereda de `Vehiculo` con propiedades
  `Color` y `Capacidad`.
- En `Program.cs` se crean instancias de `Camioneta` y `Auto`, demostrando cómo usar
  asociación (instanciación de objetos dentro de otros objetos).

## B. Estructura de archivos

```text
c#-n2-u3.6-asociacion/
└── herencia2/
    ├── herencia2.csproj
    ├── Vehiculo.cs          (Clase base)
    ├── Auto.cs              (Hereda de Vehiculo, con Composición y Agregación)
    ├── Camioneta.cs         (Hereda de Vehiculo)
    ├── Chasis.cs            (Composición)
    ├── Motor.cs             (Agregación)
    └── Program.cs
```

## C. Código

**Ruta:** `herencia2/Vehiculo.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    class Vehiculo
    {
    }
}
```

**Ruta:** `herencia2/Auto.cs`

```csharp
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
```

**Ruta:** `herencia2/Chasis.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    class Chasis
    {
        public string Tipo { get; set; }
    }
}
```

**Ruta:** `herencia2/Motor.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    class Motor
    {
        public int Potencia { get; set; }
        public string Tipo { get; set; }
    }
}
```

**Ruta:** `herencia2/Camioneta.cs`

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    class Camioneta : Vehiculo
    {
        public string Color { get; set; }
        public double Capacidad { get; set; }
    }
}
```

**Ruta:** `herencia2/Program.cs`

```csharp
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
            Camioneta c1 = new Camioneta();
            c1.Color = "Roja";
            c1.Capacidad = 500;

            Camioneta c2 = new Camioneta();
            c2.Color = "Azul";
            c2.Capacidad = 750;

            Camioneta c3 = new Camioneta();
            c3.Color = "Amarilla";
            c3.Capacidad = 1000;

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            ////listaCamionetas[1].Color = "Negra";
            //c2.Color = "Verde";
            //Console.WriteLine("El color es: " + listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            //foreach (Camioneta item in listaCamionetas)
            //{
            //    Console.WriteLine("Color: " + item.Color);
            //}

            Auto a1 = new Auto();

            a1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
```

## D. Dependencias y configuración

- Consola de .NET, sin paquetes NuGet.
- `<TargetFramework>net9.0</TargetFramework>`
- Comandos:
  ```
  cd herencia2
  dotnet build
  dotnet run
  ```

## E. Conceptos clave enseñados

### 1. **Composición vs. Agregación**

| Aspecto | Composición | Agregación |
|---------|-------------|------------|
| Relación | "Es parte de" | "Tiene un" |
| Ciclo de vida | Dependiente | Independiente |
| Ejemplo | Chasis en Auto | Motor en Auto |
| Responsabilidad | Padre crea/destruye | Padre no destruye |

### 2. **Herencia vs. Asociación**

- **Herencia** (IS-A): `Auto` IS-A `Vehiculo`
- **Asociación** (HAS-A): `Auto` HAS-A `Motor` y HAS-A `Chasis`

### 3. **Cuándo usar Composición**

Cuando un objeto es parte integral de otro y no puede existir de forma independiente.

### 4. **Cuándo usar Agregación**

Cuando un objeto puede existir de forma independiente y puede ser compartido por múltiples objetos.

## F. Elementos observables en el video

- Creación de instancias de objetos complejos que contienen otros objetos.
- Inicialización de propiedades en objetos asociados.
- Demostración de cómo `Auto a1 = new Auto(); a1.Motor = new Motor();` muestra agregación.
- Código comentado para mostrar opciones de uso de colecciones (que aparecen pero no se ejecutan).
