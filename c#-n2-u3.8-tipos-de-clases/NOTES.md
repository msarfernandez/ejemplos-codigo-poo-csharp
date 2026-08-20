# Clase 8: Tipos de Clases en C#

## Resumen del proyecto
Este proyecto demuestra los diferentes tipos de clases y modificadores en C#:
- **Clases sealed**: Clases que no pueden ser heredadas
- **Clases static**: Clases que solo contienen miembros estáticos
- **Clases regulares**: Clases normales que pueden ser heredadas

## Concepto principal
El video explora la diferencia entre:
1. **Clases abstractas**: No pueden ser instanciadas directamente
2. **Clases selladas (sealed)**: No pueden ser heredadas
3. **Clases estáticas (static)**: No pueden tener instancias, solo contienen miembros estáticos

## Estructura de archivos
```
herencia3/
├── Persona.cs         - Clase sellada (sealed)
├── Developer.cs       - Clase regular
├── Lider.cs          - Clase estática (static)
├── Program.cs        - Programa principal
└── herencia3.csproj  - Configuración del proyecto
```

## Código clave

### Persona.cs
- Clase **sealed** que no puede ser heredada
- Propiedades: Nombre, Apellido, Legajo

### Lider.cs
- Clase **static** que contiene solo miembros estáticos
- Método `algo()` que retorna "hola"
- No puede ser instanciada

### Program.cs
- Crea instancia de Persona
- Crea instancia de Developer
- Llama al método estático de Lider: `Lider.algo()`
- Imprime "hola" en consola

## Conceptos demostrados

### Sealed (Sellado)
Una clase sellada no puede ser heredada por ninguna otra clase. Si intentas crear una clase que herede de una clase sealed, obtendrás un error.

### Static
Una clase estática:
- No puede ser instanciada
- Solo puede contener miembros estáticos
- Es útil para agrupar métodos de utilidad relacionados

## Jerarquía de clases comentada en el código
El comentario en Program.cs muestra una jerarquía teórica:
```
Persona > Lider > Developer > Tester > Automovil
Computadora >> AireAcondicionado
```

Sin embargo, en esta clase 8, Persona es **sealed**, lo que impide que Lider o Developer hereden de ella.
