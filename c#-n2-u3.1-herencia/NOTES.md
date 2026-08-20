# c#-n2-u3.1-herencia — Reconstrucción del proyecto del video

## A. Resumen del proyecto

El video muestra, dentro de una solución de Visual Studio llamada **POO1** (que ya
contenía otros proyectos previos: `ejemplo1`, `ejemplo2`, `ejemplo3`, no desarrollados
en este video), el desarrollo de **dos proyectos de consola en C#** que ilustran el
concepto de **herencia** en POO:

- **herencia**: jerarquía `Persona` → `Developer`, `Lider`, `Tester`, `AnalistaFuncional`.
  Se parte de clases con propiedades duplicadas (`Nombre`, `Apellido`, `Legajo` en
  `Developer`) y se refactoriza moviendo esas propiedades a la clase base `Persona`,
  para luego hacer que las demás clases hereden de ella (`: Persona`), mostrando que
  las subclases acceden a los miembros heredados.
- **herencia2**: jerarquía `Vehiculo` → `Auto` → `AutoDeportivo`, `AutoUrbano`, y
  `Vehiculo` → `Camioneta`, `Moto`. Se usa para mostrar herencia multinivel,
  polimorfismo de referencia (asignar una instancia de una clase derivada a una
  variable del tipo base, p. ej. `Vehiculo v2 = new Camioneta();`) y, al final,
  un **error de compilación intencional** para mostrar qué conversiones NO son
  válidas entre clases hermanas (`Camioneta c2 = new Auto();`).

Tecnologías: **C#**, proyecto de consola de **.NET** (Visual Studio, IDE con tema
oscuro; no se llegó a ver el `.csproj` en pantalla, por lo que la versión exacta del
framework original no pudo confirmarse — ver sección E). Sin bases de datos, sin
librerías externas, sin frontend: es código puro de consola para explicar el
concepto de herencia.

## B. Estructura de archivos (tal como quedó reconstruida)

```text
c#-n2-u3.1-herencia/
├── herencia/
│   ├── herencia.csproj
│   ├── Persona.cs
│   ├── Developer.cs
│   ├── Lider.cs
│   ├── Tester.cs
│   ├── AnalistaFuncional.cs
│   └── Program.cs
├── herencia2/
│   ├── herencia2.csproj
│   ├── Vehiculo.cs
│   ├── Auto.cs
│   ├── AutoDeportivo.cs
│   ├── AutoUrbano.cs
│   ├── Camioneta.cs
│   ├── Moto.cs
│   └── Program.cs
└── NOTES.md
```

En el video, ambos proyectos convivían dentro de la misma solución `POO1.sln` junto
con `ejemplo1`, `ejemplo2` y `ejemplo3` (no desarrollados en este video, por lo que
no se reconstruyeron). Aquí se dejaron como dos proyectos de consola independientes
para que cada video pueda vivir en su propia carpeta dentro de `código/`.

## C. Notas de coherencia

- `herencia2` **no compila** tal como queda al final del video: la línea
  `Camioneta c2 = new Auto();` produce el error `CS0029` (no se puede convertir
  implícitamente `Auto` a `Camioneta`). Esto se verificó reconstruyendo el `.csproj`
  y compilando con `dotnet build`: se reproduce exactamente el mismo error que
  aparece en pantalla en el IDE. Se dejó tal cual porque es la última versión
  del código mostrada en el video, y el presentador lo usa a propósito como
  ejemplo de qué NO es válido en una jerarquía de herencia (no dice en el
  video que lo vaya a corregir después).
- `herencia` sí compila sin errores.

## D. Dependencias y configuración

- No hay paquetes NuGet ni dependencias externas: son proyectos de consola "vacíos"
  generados desde la plantilla estándar de Visual Studio.
- Comandos para compilar y ejecutar (con el SDK de .NET instalado):
  ```
  cd herencia
  dotnet run

  cd ../herencia2
  dotnet build   # falla intencionalmente con CS0029 (ver sección C)
  ```

## E. Elementos inferidos (no observados con total certeza en el video)

- **`Tester.cs` (`herencia`)**: no se vio en pantalla el contenido de este archivo
  editado con `: Persona`. Se infiere por el patrón repetido en `Developer.cs`,
  `Lider.cs` y `AnalistaFuncional.cs`, y por el comentario del propio código
  `//Persona > Lider > Developer > Tester > Automovil`. Marcado con comentario
  `INFERIDO` en el archivo.
- **`AutoUrbano.cs` (`herencia2`)**: no se vio en pantalla el momento exacto en que
  se le agrega `: Auto`. Se infiere por simetría con `AutoDeportivo.cs` (creada en
  el mismo bloque de edición) y por el comentario `//Vehiculo > Auto > AutoDeportivo
  > AutoUrbano`. Marcado con comentario `INFERIDO` en el archivo.
- **Versión exacta de .NET / target framework**: nunca se vio el archivo `.csproj`
  en pantalla. Se asumió `net8.0` (SDK-style) para que el código sea compilable con
  `dotnet` fuera de Visual Studio; el original probablemente era un proyecto de
  consola clásico de .NET Framework generado por el asistente de Visual Studio
  (por la UI del "Add New Item" y el estilo del IDE, compatible con VS 2019/2022).
  Esto no afecta al código C# en sí, que se transcribió tal como aparece en pantalla.
- Los comentarios de ejemplo `//Computadora >> AireAcondicionado` (en `herencia`) y
  las líneas `//Vehiculo > Auto > AutoDeportivo > AutoUrbano` / `//>Camioneta` /
  `//>Moto` (en `herencia2`) son anotaciones del propio presentador dentro de
  `Main`, dejadas como comentarios explicativos; no se implementaron como clases
  porque en el video no se desarrollan (`Automovil`, `Computadora`,
  `AireAcondicionado` no llegan a crearse como archivos `.cs`).
- No se pudo determinar con certeza si en el segmento final de `Program.cs` de
  `herencia` (proyecto `herencia`) se llegó a completar una línea con
  `l1.Nombre`/`l1.Apellido`/`l1.Legajo` (se ve un autocompletado de Visual Studio
  abierto sobre `l1.` con esas opciones, pero el video corta a la clase
  `AnalistaFuncional` antes de mostrar cuál se eligió, si es que se eligió alguna).
  Por eso esa línea no se incluyó en la reconstrucción final.
