# Clase 8: Tipos de Clases - Sealed y Static

## Descripción General
Esta clase explora dos modificadores de clase importantes en C#: `sealed` y `static`.

## Conceptos clave

### 1. Clases Sealed (Selladas)
Una clase marcada con `sealed` **no puede ser heredada**.

```csharp
sealed class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Legajo { get; set; }
}
```

**Ventajas:**
- Control de herencia
- Previene cambios no deseados en la jerarquía de clases
- Puede optimizar el rendimiento (compilador sabe que no hay subclases)

**Ejemplo de error:**
```csharp
class Lider : Persona  // ❌ ERROR: No se puede heredar de una clase sealed
{
}
```

### 2. Clases Static (Estáticas)
Una clase marcada con `static`:
- **No puede ser instanciada**
- Solo puede contener **miembros estáticos** (métodos, propiedades, campos)
- Es útil para agrupar funcionalidad relacionada

```csharp
static class Lider
{
    public static string algo()
    {
        return "hola";
    }
}
```

**Uso:**
```csharp
Lider.algo();  // ✓ Correcto: llamar método estático
Lider l = new Lider();  // ❌ ERROR: No se puede instanciar
```

## Estructura del proyecto

### Archivos incluidos

**Persona.cs**
- Clase sealed con propiedades de atributos básicos
- Demuestra el concepto de clase no heredable

**Lider.cs**
- Clase static con método static
- Demuestra cómo usar utilidades sin crear instancias

**Developer.cs**
- Clase regular vacía (para demostración)

**Program.cs**
- Crea instancia de Persona
- Crea instancia de Developer
- Llama a método estático de Lider
- Imprime salida en consola

## Ejecución

Para compilar y ejecutar el proyecto:

```bash
cd herencia3
dotnet run
```

**Salida esperada:**
```
hola
```

## Casos de uso

### Sealed
- Clases que representan conceptos finales (como `string` en .NET)
- Cuando no quieres que se herede de tu clase
- Proteger implementaciones críticas

### Static
- Métodos de utilidad (Math, Console)
- Configuraciones globales
- Helpers de aplicación
- Cuando la funcionalidad no requiere estado de instancia

## Relación con otras clases

Este proyecto es parte de una serie que explora jerarquías de herencia:
- **Clase 1-7**: Herencia, tipos de datos, colecciones, interfaces
- **Clase 8**: Tipos de clases (sealed, static) ← TÚ ESTÁS AQUÍ
- **Clase 9**: Modelo de dominio

La estructura teórica mencionada en los comentarios:
```
Persona > Lider > Developer > Tester > Automovil
Computadora >> AireAcondicionado
```

Sin embargo, en esta clase 8, Persona es **sealed**, lo que demuestra una limitación práctica.
