# c#-n2-u3.4-sobreescritura-de-metodos — Reconstrucción del proyecto del video

## A. Resumen del proyecto

Este video crea un **proyecto nuevo** dentro de la misma solución `POO1`:
**`herencia3`** (sexto proyecto de la solución, junto a `ejemplo1`, `ejemplo2`,
`ejemplo3`, `herencia` y `herencia2` de videos anteriores). Desarrolla una
jerarquía de animales para explicar **sobreescritura de métodos**
(`override`/`virtual`) y **polimorfismo** con listas de la clase base:

```
Animal
├── AnimalDomestico
│   ├── Gato      (override comunicarse() -> "miau miau....")
│   ├── Perro     (override comunicarse() -> "Guau guau....")
│   └── Canario
└── AnimalSalvaje
    ├── Pez
    ├── Aguila
    └── Tigre
```

Puntos clave mostrados en el video:

- `Animal` define `public virtual string comunicarse()` con la implementación
  por defecto `"ruido... ruido..."`.
- `AnimalDomestico : Animal` agrega la propiedad `Nombre` y sobreescribe
  `ToString()` (`"Animal Doméstico: " + Nombre`) — se prueba primero con
  `Console.WriteLine(a1.ToString())` sobre un `Animal` "pelado" (sin override,
  imprime el nombre completo de la clase, comportamiento por defecto de
  `object.ToString()`), y luego se muestra cómo cambia al heredar de
  `AnimalDomestico`.
- `Gato` y `Perro` heredan de `AnimalDomestico` y sobreescriben
  `comunicarse()` cada uno con su propio sonido.
- Se muestra un **casteo explícito** (`Gato g8 = (Gato)a1;`), incluyendo el
  error de compilación `CS0266` que aparece al intentar la asignación
  implícita `Gato g8 = a1;` sin el cast — se transcribió como comentario en
  el propio código de ejemplo mental, no quedó en el `Program.cs` final
  porque esa parte del código fue reemplazada por la versión con
  `List<Animal>` (ver sección C).
- Se arma un `List<Animal>` con instancias de varias subclases (`Perro`,
  `Pez`, `Canario`, `Gato`, `Aguila`, otro `Gato`) y se recorre con un
  `foreach (Animal item in animales)` imprimiendo `item.comunicarse()`,
  demostrando que cada objeto ejecuta **su propia versión sobreescrita** del
  método (polimorfismo).
- Salida final de la ejecución (verificada compilando y corriendo el
  proyecto reconstruido — coincide exactamente):
  ```
  Guau guau....
  ruido... ruido...
  ruido... ruido...
  miau miau....
  ruido... ruido...
  miau miau....
  ```

## B. Estructura de archivos

```text
c#-n2-u3.4-sobreescritura-de-metodos/
└── herencia3/
    ├── herencia3.csproj
    ├── Animal.cs
    ├── AnimalDomestico.cs
    ├── AnimalSalvaje.cs
    ├── Gato.cs
    ├── Perro.cs
    ├── Pez.cs          (INFERIDO, ver sección E)
    ├── Canario.cs      (INFERIDO, ver sección E)
    ├── Aguila.cs       (INFERIDO, ver sección E)
    ├── Tigre.cs        (INFERIDO, ver sección E — nunca se usa en Program.cs)
    └── Program.cs
```

## C. Notas de coherencia / evolución del código

- Antes de llegar a la versión final con `List<Animal>`, el video muestra un
  tramo intermedio en `Program.cs` con `Animal a1 = g1;` y
  `Gato g8 = (Gato)a1;` (casteo explícito, downcasting) impreso con
  `Console.WriteLine(g8.Nombre)` → salida `"BLANQUITO"` en pantalla. Esa
  parte quedó **comentada y luego reemplazada** por el bloque final con
  `List<Animal>` y `foreach`, que es el que se ve compilando y ejecutándose
  al cierre del video. Por eso no se incluyó en el `Program.cs`
  reconstruido: siguiendo la regla de "usar la versión final resultante,
  no duplicar código reemplazado".
- El proyecto compila y ejecuta sin errores en su estado final (verificado).

## D. Dependencias y configuración

- Consola de .NET, sin paquetes NuGet, mismo estilo que los proyectos de los
  videos anteriores de esta unidad.
- `<TargetFramework>net9.0</TargetFramework>` (ver nota sobre versión de
  framework en `código/c#-n2-u3.1-herencia/NOTES.md`; el video tampoco
  muestra el `.csproj` acá).
- Comandos:
  ```
  cd herencia3
  dotnet run
  ```

## E. Elementos inferidos

- **`Pez.cs`, `Canario.cs`, `Aguila.cs`**: se ven creados en el Solution
  Explorer y se instancian en `Program.cs` (`new Pez()`, `new Canario()`,
  `new Aguila()`), y su salida en la ejecución final confirma que **no
  sobreescriben `comunicarse()`** (imprimen el `"ruido... ruido..."` por
  defecto de `Animal`). Pero el video nunca abre estos tres archivos en
  pantalla, así que su clase base exacta (`AnimalDomestico` vs
  `AnimalSalvaje`) no pudo confirmarse. Se infirió por semántica del nombre:
  `Canario` → `AnimalDomestico`, `Pez` y `Aguila` → `AnimalSalvaje`. Marcado
  con comentario `INFERIDO` en cada archivo.
- **`Tigre.cs`**: existe en el Solution Explorer durante todo el video pero
  nunca se abre ni se instancia en `Program.cs`. Su contenido completo es
  una inferencia (clase vacía heredando de `AnimalSalvaje`, siguiendo el
  patrón del resto de animales salvajes). Marcado con comentario `INFERIDO`.
- No se pudo determinar si `Tester`-like reflexiones adicionales (por
  ejemplo, si `AnimalSalvaje` o `AnimalDomestico` llegaron a tener alguna
  propiedad propia más allá de lo mostrado) existían, ya que ambos archivos
  se vieron siempre vacíos (`{ }`) en los momentos capturados del video.
