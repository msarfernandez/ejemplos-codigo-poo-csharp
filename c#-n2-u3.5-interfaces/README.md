# Clase 5: Interfaces en C#

## Resumen

Este proyecto demuestra el concepto de **interfaces** en C#, continuando la jerarquía de animales
de la clase anterior.

## Conceptos Clave

### 1. **Interfaz Flyable**

```csharp
interface Flyable
{
    string volar();
}
```

Una interfaz es un **contrato** que especifica qué miembros (métodos, propiedades) debe implementar
cualquier clase que la adopte. No proporciona implementación, solo define la firma.

### 2. **Implementación de Interfaces**

Las clases pueden implementar una interfaz (y heredar de una clase base simultáneamente):

```csharp
class Canario : AnimalDomestico, Flyable
{
    public string volar()
    {
        return "vuela como un canario...";
    }
}
```

### 3. **Polimorfismo mediante Interfaces**

Se pueden crear colecciones usando la interfaz como tipo genérico:

```csharp
List<Flyable> listaVoladores = new List<Flyable>();
listaVoladores.Add(new Canario());
listaVoladores.Add(new Aguila());

foreach (Flyable item in listaVoladores)
{
    Console.WriteLine(item.volar()); // Polimorfismo
}
```

## Jerarquía de Clases

```
Animal (base virtual comunicarse)
├── AnimalDomestico (hereda Nombre)
│   ├── Gato (override comunicarse → "miau miau....")
│   ├── Perro (override comunicarse → "Guau guau....")
│   └── Canario (implements Flyable → volar: "vuela como un canario...")
└── AnimalSalvaje
    ├── Pez
    ├── Aguila (implements Flyable → volar: "vuela como un águila...")
    └── Tigre
```

## Diferencia entre Herencia e Interfaces

| Característica | Herencia | Interfaz |
|---|---|---|
| Hereda comportamiento | Sí | No |
| Multiple | No (en C#) | Sí |
| Define contrato | No | Sí |
| Implementación en clase | Sí | No |
| Método virtual | Puede ser | No |

## Comandos

```bash
# Compilar
dotnet build

# Ejecutar
dotnet run
```

## Archivos Principales

- **Flyable.cs**: Define la interfaz
- **Canario.cs**: Implementa Flyable
- **Aguila.cs**: Implementa Flyable
- **Program.cs**: Demuestra el uso de polimorfismo con interfaces
