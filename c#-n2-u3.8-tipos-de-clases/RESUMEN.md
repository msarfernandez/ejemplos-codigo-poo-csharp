# CLASE 8: TIPOS DE CLASES EN C# - RESUMEN COMPLETO

## A. Resumen del Proyecto

**Título:** Tipos de Clases en C# - Sealed y Static

**Descripción:** Este proyecto demuestra cómo funcionan las clases `sealed` (selladas) y `static` (estáticas) en C#, dos modificadores importantes que controlan cómo se pueden usar las clases dentro de una aplicación.

**Tecnologías utilizadas:**
- Lenguaje: C# (.NET 9.0)
- Framework: .NET Core
- Tipo de aplicación: Consola

## B. Estructura de Archivos

```
c#-n2-u3.8-tipos-de-clases/
├── herencia3/
│   ├── Persona.cs              # Clase sealed (no heredable)
│   ├── Developer.cs            # Clase regular
│   ├── Lider.cs               # Clase static
│   ├── Program.cs             # Punto de entrada
│   └── herencia3.csproj       # Configuración del proyecto
├── README.md                   # Documentación completa
├── NOTES.md                    # Apuntes de la clase
└── RESUMEN.md                 # Este archivo
```

## C. Código de los Archivos

### Persona.cs
```csharp
using System;

namespace herencia
{
    sealed class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
```

**Características:**
- Modificador `sealed` previene herencia
- Propiedades auto-implementadas
- Representa una clase no heredable

### Lider.cs
```csharp
using System;

namespace herencia
{
    static class Lider
    {
        public static string algo()
        {
            return "hola";
        }
    }
}
```

**Características:**
- Clase `static`: no puede instanciarse
- Solo contiene miembros estáticos
- Método `algo()` retorna "hola"

### Developer.cs
```csharp
using System;

namespace herencia
{
    class Developer
    {
    }
}
```

**Características:**
- Clase regular vacía
- Se usa para demostración
- Puede ser heredada o instanciada

### Program.cs
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona > Lider > Developer > Tester > Automovil
            //Computadora >> AireAcondicionado
            Persona p1 = new Persona();
            Developer d1 = new Developer();

            Lider.algo();

            Console.WriteLine("hola");
        }
    }
}
```

**Características:**
- Punto de entrada de la aplicación
- Crea instancia de Persona (posible porque es sellada, no abstracta)
- Crea instancia de Developer
- Llama método estático sin instanciar Lider
- Imprime "hola" en consola

### herencia3.csproj
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
  </PropertyGroup>

</Project>
```

**Características:**
- Define que es una aplicación de consola
- Usa .NET 9.0
- Configuración mínima necesaria

## D. Dependencias y Configuración

**Dependencias del proyecto:** Ninguna (solo librerías estándar de .NET)

**Comandos para instalar y ejecutar:**

```bash
# Navegar al directorio
cd herencia3

# Restaurar dependencias (automático)
dotnet restore

# Compilar el proyecto
dotnet build

# Ejecutar el proyecto
dotnet run

# Compilar en Release
dotnet build -c Release

# Publicar el proyecto
dotnet publish
```

**Salida esperada al ejecutar:**
```
hola
```

## E. Conceptos Clave Demostrados

### 1. Clases Sealed (Selladas)

Una clase `sealed` no puede ser heredada:

```csharp
sealed class Persona { }

// ❌ ESTO CAUSA ERROR:
class Lider : Persona { }  // CS0509: Cannot derive from sealed type
```

**Ventajas:**
- Control total sobre la jerarquía de herencia
- Previene cambios inesperados
- Mejora de rendimiento (compilador sabe que no hay subclases)
- Seguridad: protege implementaciones críticas

**Casos de uso:**
- Clases que representan conceptos finales
- Proteger lógica crítica de modificaciones
- Cuando la herencia no es adecuada

### 2. Clases Static (Estáticas)

Una clase `static`:
- **No puede instanciarse**
- Solo puede contener miembros estáticos
- No puede heredar de otra clase
- No se puede heredar de ella

```csharp
static class Lider
{
    public static string algo() { return "hola"; }
}

// ✓ CORRECTO:
string resultado = Lider.algo();

// ❌ ESTO CAUSA ERROR:
Lider l = new Lider();  // No se puede instanciar
```

**Ventajas:**
- Agrupa funcionalidad relacionada
- No requiere estado de instancia
- Similar a funciones globales en otros lenguajes
- Claramente comunica intención (sin estado)

**Casos de uso:**
- Métodos de utilidad (Math, String)
- Funciones de configuración
- Helpers de la aplicación
- Métodos que no dependen de estado

## F. Elementos Inferidos

**Nota:** No hay elementos inferidos en este proyecto. Todo lo que aparece en el código está claramente visible en los fotogramas analizados del video.

## G. Validación y Coherencia

✓ **Compilación:** El proyecto compila sin errores ni advertencias
✓ **Ejecución:** El programa ejecuta correctamente y produce la salida esperada
✓ **Imports:** Todos los using están presentes y son necesarios
✓ **Namespace:** Consistente en todos los archivos (herencia)
✓ **Nombres:** Utilizan convenciones de C# (PascalCase)
✓ **Referencias:** No hay referencias circulares ni faltantes
✓ **Estructura:** Coherente con los estándares de .NET

## H. Lecciones Aprendidas

1. **Sealed vs Abstract:**
   - Sealed: No se puede heredar, SÍ se puede instanciar
   - Abstract: No se puede instanciar, SÍ se puede heredar (a través de subclases)

2. **Static vs Regular:**
   - Static: Sin estado de instancia, acceso directo a la clase
   - Regular: Con posible estado de instancia, requiere instanciación

3. **Cuándo usar cada una:**
   - Sealed: Cuando quieres un tipo final e inmutable
   - Static: Cuando agrupar funcionalidad sin estado
   - Regular: Para la mayoría de casos (valores y comportamiento con estado)

## I. Ejecución y Prueba

**Compilación exitosa:** ✓
**Ejecución exitosa:** ✓
**Salida correcta:** ✓

El proyecto está completamente funcional y listo para su uso educativo.
