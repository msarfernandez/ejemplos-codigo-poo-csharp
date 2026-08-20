# c#-n2-u3.3-colecciones — Reconstrucción del proyecto del video

## A. Resumen del proyecto

Este video **continúa directamente sobre el proyecto `herencia2`** creado en el
video anterior (`c#-n2-u3.1-herencia`), dentro de la misma solución de Visual
Studio `POO1`. No se crea un proyecto nuevo: se reutilizan las clases
`Vehiculo`, `Auto`, `AutoDeportivo`, `AutoUrbano`, `Camioneta` y `Moto`, y se
reescribe `Program.cs` para introducir **colecciones (`List<T>`)**.

Por eso esta carpeta contiene una **copia completa y actualizada** de
`herencia2` (no solo un diff), para que el video quede autocontenido. Los
archivos que no se tocan en este video (`Auto.cs`, `AutoDeportivo.cs`,
`AutoUrbano.cs`, `Camioneta.cs`, `Moto.cs`) son copia exacta de
`código/c#-n2-u3.1-herencia/herencia2/`.

Contenido nuevo mostrado en el video:

- Se agrega la propiedad `Color` a la clase base `Vehiculo` (además de la
  `Motor` que ya existía).
- Se crean tres `Camioneta` (`c1`, `c2`, `c3`) con colores distintos y se
  agregan a una `List<Camioneta> listaCamionetas`.
- Se muestra `listaCamionetas.Count`.
- Se muestra (y luego se comenta) cómo modificar un elemento accediendo por
  índice (`listaCamionetas[1].Color = "Negra"`) y cómo modificarlo a través de
  la variable original (`c2.Color = "Verde"`), para reforzar que la lista
  guarda **referencias** a los mismos objetos (enlaza con el video anterior
  sobre tipos por referencia). Aparece un diagrama (c1/c2/c3 → obj1/obj2/obj3,
  lista[0]/[1]/[2] → los mismos objetos).
- Se muestra (y luego se comenta) `listaCamionetas.Remove(c3)` con el
  `Count` antes y después.
- Se reemplazan esas pruebas comentadas por un `foreach (Camioneta item in
  listaCamionetas)` que imprime el color de cada camioneta.
- Se ejecuta el programa: la salida final es
  ```
  Color: Amarillo
  Color: Roja
  Color: Blanca
  ```
  (se verificó reconstruyendo y compilando el proyecto: la salida coincide
  exactamente).

## B. Estructura de archivos

```text
c#-n2-u3.3-colecciones/
├── herencia2/
│   ├── herencia2.csproj
│   ├── Auto.cs              (sin cambios respecto al video 1)
│   ├── AutoDeportivo.cs     (sin cambios respecto al video 1)
│   ├── AutoUrbano.cs        (sin cambios respecto al video 1)
│   ├── Camioneta.cs         (sin cambios respecto al video 1)
│   ├── Moto.cs               (sin cambios respecto al video 1)
│   ├── Vehiculo.cs          (ACTUALIZADO: se agrega la propiedad Color)
│   └── Program.cs           (REESCRITO: demo de List<Camioneta>)
└── NOTES.md
```

## C. Notas de coherencia

- El video 1 (`c#-n2-u3.1-herencia/herencia2/Program.cs`) terminaba con un
  error de compilación intencional (`CS0029`). Este video **reescribe por
  completo** `Program.cs`, así que ese error queda atrás: el `Program.cs` de
  esta carpeta compila y ejecuta sin errores (verificado con `dotnet build` y
  `dotnet run`).
- En `Vehiculo.cs` quedó un comentario `//Motor` justo antes de la propiedad
  `Motor` — se transcribió tal cual aparece en pantalla (parece un comentario
  residual del presentador, no tiene efecto funcional).
- Durante la edición en el video hubo un момento transitorio con un error de
  autocompletado (`public string Color MyProperty { get; set; }`, 14 errores
  de compilación en el IDE) que el presentador corrigió de inmediato borrando
  `MyProperty`. No se reconstruyó ese estado intermedio porque no es el
  código final.

## D. Dependencias y configuración

- Mismo tipo de proyecto que el video 1: consola de .NET, sin paquetes NuGet.
- Se ajustó `<TargetFramework>` a `net9.0` en los `.csproj` (video 1 y este)
  para poder compilar/ejecutar con el SDK de .NET disponible en este entorno;
  el video no muestra el `.csproj`, así que la versión exacta del framework
  original sigue sin poder confirmarse (ver NOTES del video 1).
- Comandos:
  ```
  cd herencia2
  dotnet run
  ```

## E. Elementos inferidos

- Se asume que `Camioneta.cs`, `Auto.cs`, `AutoDeportivo.cs`, `AutoUrbano.cs`
  y `Moto.cs` **no cambiaron** respecto al video anterior, porque en ningún
  momento de este video se los abre ni se los edita (solo se ve su nombre en
  el Solution Explorer). Es la inferencia más simple y consistente con lo
  observado, pero no hay confirmación visual directa de su contenido en
  *este* video.
