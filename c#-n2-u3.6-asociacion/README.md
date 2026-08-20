# Clase 6: Asociación en C# (Composición y Agregación)

## Resumen

Este proyecto demuestra dos formas fundamentales de **asociar objetos** en programación orientada a objetos:
la **composición** y la **agregación**.

## Conceptos Clave

### 1. **Composición (HAS-A fuerte)**

```csharp
public Chasis Chasis { get; set; }  // Composición
```

- El Auto **contiene** un Chasis
- El Chasis es **parte integral** del Auto
- Si el Auto se destruye, el Chasis también
- Relación de **propietario y propiedad**

### 2. **Agregación (HAS-A débil)**

```csharp
public Motor Motor { get; set; }  // Agregación
```

- El Auto **tiene** un Motor
- El Motor puede existir **independientemente**
- Si el Auto se destruye, el Motor puede sobrevivir
- Relación más **flexible** y **débil**

## Diferencia Visual

```
┌─────────────────────────────┐
│         Auto                │
│ ┌───────────────────────┐   │
│ │    Chasis (DENTRO)    │   │  COMPOSICIÓN
│ │                       │   │  (Parte integral)
│ └───────────────────────┘   │
│                             │
│  Motor [Referencia]         │  AGREGACIÓN
│  ↓ (Puede no existir)       │  (Intercambiable)
└─────────────────────────────┘
        ↓
   ┌──────────┐
   │  Motor   │  Puede existir
   │ independ │  independientemente
   └──────────┘
```

## Jerarquía de Clases

```
Vehiculo (base)
├── Auto
│   ├─ Propiedades simples: Anio, Modelo, Color
│   ├─ Composición: Chasis
│   └─ Agregación: Motor
└── Camioneta
    ├─ Color
    └─ Capacidad
```

## Código Ejemplo

```csharp
// Crear un Auto
Auto a1 = new Auto();

// Agregar un Motor (Agregación)
a1.Motor = new Motor();
a1.Motor.Potencia = 150;

// Crear Camionetas
Camioneta c1 = new Camioneta();
c1.Color = "Roja";
c1.Capacidad = 500;
```

## Diferencia con Herencia

| Concepto | Herencia | Asociación |
|----------|----------|-----------|
| Relación | IS-A (es un) | HAS-A (tiene un) |
| Ejemplo | Auto IS-A Vehiculo | Auto HAS-A Motor |
| Acceso | Heredar métodos | Acceder a propiedades |
| Código | `: Vehiculo` | `{ get; set; }` |

## Cuándo usar cada una

### Usa Composición cuando:
- El objeto es **parte integral** del padre
- No puede existir sin el padre
- Ejemplo: Ruedas en un Auto

### Usa Agregación cuando:
- El objeto es **independiente**
- Puede ser **compartido** por varios padres
- Ejemplo: Motor en un Auto (puede ser reemplazado)

## Comandos

```bash
# Compilar
dotnet build

# Ejecutar
dotnet run
```

## Archivos Principales

- **Vehiculo.cs**: Clase base
- **Auto.cs**: Demuestra composición y agregación
- **Chasis.cs**: Componente (composición)
- **Motor.cs**: Agregación
- **Camioneta.cs**: Otra subclase de Vehiculo
- **Program.cs**: Demostración de uso
