# DIAGRAMA DEL MODELO DE DOMINIO

## Diagrama UML - Modelo Empresa Tecnológica (Clase 7)

### Representación ASCII

```
┌─────────────────────────────────────────────────────────────────┐
│                         JERARQUÍA DE HERENCIA                   │
└─────────────────────────────────────────────────────────────────┘

                            ┌──────────────┐
                            │    Persona   │
                            ├──────────────┤
                            │ - Nombre     │
                            │ - Telefono   │
                            │ - Direccion  │
                            ├──────────────┤
                            │ + saludar()  │
                            └──────┬───────┘
                                   │
                 ┌─────────────────┴─────────────────┐
                 │                                   │
         ┌───────▼────────┐             ┌────────────▼──────┐
         │   Developer    │             │     Tester       │
         ├────────────────┤             ├──────────────────┤
         │ - Lenguajes    │             │ - NivelEstress   │
         │ - Seniority    │             │                  │
         ├────────────────┤             ├──────────────────┤
         │+ tirarUnHola   │             │                  │
         │  Mundo()       │             │                  │
         └────────────────┘             └──────────────────┘

┌─────────────────────────────────────────────────────────────────┐
│                     RELACIÓN HAS-A (Composición)                │
└─────────────────────────────────────────────────────────────────┘

    ┌──────────────┐                   ┌──────────────────┐
    │   Persona    │ HAS-A (1)  (1)    │   Direccion      │
    ├──────────────┤ ─────────────────>├──────────────────┤
    │ - Nombre     │                   │ - Calle          │
    │ - Telefono   │                   │ - Ciudad         │
    │ - Direccion  │                   │ - Provincia      │
    │              │                   │ - CodigoPostal   │
    └──────────────┘                   │ - Pais           │
                                       └──────────────────┘

┌─────────────────────────────────────────────────────────────────┐
│              RELACIÓN HAS-A (Agregación) - VEHICULOS            │
└─────────────────────────────────────────────────────────────────┘

                            ┌──────────────┐
                            │   Vehiculo   │
                            │   (abstracta)│
                            └──────┬───────┘
                                   │
                 ┌─────────────────┴─────────────────┐
                 │                                   │
         ┌───────▼────────┐             ┌────────────▼──────┐
         │      Auto      │             │    Camioneta     │
         ├────────────────┤             ├──────────────────┤
         │ - Anio         │             │ - Color          │
         │ - Modelo       │             │ - Capacidad      │
         │ - Color        │             └──────────────────┘
         │ + Chasis       │  COMPOSICIÓN
         │ + Motor        │  AGREGACIÓN
         └────────────────┘
             │         │
             │         └──────────────┐
             │                        │
       COMPOSICIÓN              AGREGACIÓN
       (parte integral)        (intercambiable)
             │                        │
             ▼                        ▼
         ┌─────────┐             ┌────────┐
         │ Chasis  │             │ Motor  │
         ├─────────┤             ├────────┤
         │ - Tipo  │             │- Potencia
         └─────────┘             │- Tipo  │
                                 └────────┘
                                 
                    NO puede existir   PUEDE existir
                    sin Auto           sin Auto
```

---

## Diagrama de Relaciones Detallado

### Relación: Persona → Developer/Tester (IS-A)

```
┌─────────────────────────────────────────────────────────┐
│                    HERENCIA (IS-A)                      │
├─────────────────────────────────────────────────────────┤
│                                                         │
│  Developer IS-A Persona  ←  Developer ES-UN Persona    │
│  Tester IS-A Persona     ←  Tester ES-UN Persona       │
│                                                         │
│  IMPLICA:                                               │
│  ✓ Developer hereda todos los atributos de Persona     │
│  ✓ Developer hereda todos los métodos de Persona       │
│  ✓ Developer AGREGA nuevos atributos (Lenguajes)       │
│  ✓ Developer AGREGA nuevos métodos (tirarUnHolaMundo)  │
│  ✓ Puede haber listas de Persona que contengan tanto   │
│    Developer como Tester (POLIMORFISMO)                │
│                                                         │
└─────────────────────────────────────────────────────────┘
```

### Relación: Persona → Direccion (HAS-A Composición)

```
┌─────────────────────────────────────────────────────────┐
│           COMPOSICIÓN (HAS-A FUERTE)                    │
├─────────────────────────────────────────────────────────┤
│                                                         │
│  Persona HAS-A Direccion  ←  Persona TIENE-UNA Dir.    │
│                                                         │
│  CARACTERÍSTICAS:                                       │
│  • Relación 1:1 (una Persona, una Direccion)           │
│  • La Direccion ES PARTE DE Persona                    │
│  • Si Persona se destruye → Direccion se destruye      │
│  • No se puede tener Direccion sin Persona             │
│  • Responsabilidad: Persona → Direccion                │
│                                                         │
│  CICLO DE VIDA:                                         │
│  Crear Persona → Automáticamente crea Direccion        │
│  Eliminar Persona → Automáticamente elimina Direccion  │
│                                                         │
└─────────────────────────────────────────────────────────┘
```

### Relación: Auto → Motor (HAS-A Agregación)

```
┌─────────────────────────────────────────────────────────┐
│           AGREGACIÓN (HAS-A DÉBIL)                      │
├─────────────────────────────────────────────────────────┤
│                                                         │
│  Auto HAS-A Motor  ←  Auto TIENE-UN Motor              │
│                                                         │
│  CARACTERÍSTICAS:                                       │
│  • Relación flexible (puede o no estar presente)       │
│  • El Motor NO ES PARTE INTEGRAL del Auto              │
│  • Si Auto se destruye → Motor PUEDE sobrevivir        │
│  • Se puede tener Motor sin Auto (en un almacén)       │
│  • Responsabilidad independiente: Auto ≠ Motor        │
│                                                         │
│  CICLO DE VIDA:                                         │
│  Crear Auto → Motor se asigna DESPUÉS                  │
│  Eliminar Auto → Motor puede ser reasignado a otro Auto│
│                                                         │
│  EJEMPLO DE USO:                                        │
│  Auto a1 = new Auto();     // Auto existe               │
│  a1.Motor = null;          // Sin motor (válido)        │
│  a1.Motor = new Motor();   // Se le asigna un motor    │
│  a1.Motor = motorUsado;    // Se remplaza por otro     │
│                                                         │
└─────────────────────────────────────────────────────────┘
```

---

## Comparación: Composición vs Agregación

```
┌──────────────────────────────────────────────────────────────┐
│           COMPOSICIÓN vs AGREGACIÓN                          │
├─────────────────────────┬──────────────────────────────────┤
│     COMPOSICIÓN          │      AGREGACIÓN                  │
├─────────────────────────┼──────────────────────────────────┤
│ Relación: "es parte de" │ Relación: "tiene un"             │
│ Ciclo de vida: Unido    │ Ciclo de vida: Independiente     │
│ Cardinality: 1:1        │ Cardinality: 1:N o 1:1           │
│ Existencia: Obligatoria │ Existencia: Opcional             │
│ Eliminación: En cascada │ Eliminación: Independiente       │
│                         │                                  │
│ Ejemplos:              │ Ejemplos:                        │
│ • Chasis en Auto       │ • Motor en Auto                  │
│ • Corazón en Persona   │ • Conductor en Auto              │
│ • Puertas en Auto      │ • Pasajeros en Auto              │
│                         │ • Empleados en Empresa           │
│                         │                                  │
│ Destrucción:           │ Destrucción:                     │
│ Auto se destruye       │ Auto se destruye                 │
│    ↓                   │    ↓ (pero)                      │
│ Chasis MUERE           │ Motor SIGUE VIVO (reasignado)    │
│                         │                                  │
└─────────────────────────┴──────────────────────────────────┘
```

---

## Estructura Completa: Diagrama de Clases

```
                    ╔═══════════════════╗
                    ║     Vehiculo      ║ (Base)
                    ╚═════════╤═════════╝
                              │
                    ┌─────────┴─────────┐
                    │                   │
            ╔═══════▼════════╗  ╔════════▼═════════╗
            ║      Auto      ║  ║    Camioneta    ║
            ╠════════════════╣  ╠═════════════════╣
            ║ + Anio: int    ║  ║ + Color: str    ║
            ║ + Modelo: str  ║  ║ + Capacidad: dbl║
            ║ + Color: str   ║  ╚═════════════════╝
            ║ + Chasis: ○    ║ ← COMPOSICIÓN
            ║ + Motor: ◇     ║ ← AGREGACIÓN
            ╚════════════════╝
                    │      │
                    │      └──────────────────┐
                    │                         │
             COMPOSICIÓN              AGREGACIÓN
                    │                         │
        ╔═══════════▼═════════╗   ╔═══════════▼════════╗
        ║      Chasis        ║   ║      Motor        ║
        ╠════════════════════╣   ╠═══════════════════╣
        ║ + Tipo: str        ║   ║ + Potencia: int   ║
        ║                    ║   ║ + Tipo: str       ║
        ╚════════════════════╝   ╚═══════════════════╝
        
        Dependencia fuerte      Dependencia débil
        (parte del objeto)      (puede reemplazarse)


                    ╔═════════════════╗
                    ║     Persona     ║ (Base)
                    ╠═════════════════╣
                    ║ + Nombre: str   ║
                    ║ + Telefono: str ║
                    ║ + Direccion: ○  ║ ← COMPOSICIÓN
                    ║ + saludar()     ║
                    ╚════════╤════════╝
                             │
                    ┌────────┴────────┐
                    │                 │
            ╔═══════▼═══════╗  ╔═══════▼═════════╗
            ║  Developer    ║  ║     Tester      ║
            ╠═══════════════╣  ╠═════════════════╣
            ║+ Lenguajes    ║  ║+ NivelEstress   ║
            ║+ Seniority    ║  ║                 ║
            ║+ tirarUnHola  ║  ╚═════════════════╝
            ║  Mundo()      ║
            ╚═══════════════╝

            ╔═══════════════════════╗
            ║     Direccion         ║
            ╠═══════════════════════╣
            ║ + Calle: str          ║
            ║ + Ciudad: str         ║
            ║ + Provincia: str      ║
            ║ + CodigoPostal: str   ║
            ║ + Pais: str           ║
            ╚═══════════════════════╝

Leyenda:
○ = Composición (parte integral)
◇ = Agregación (intercambiable)
```

---

## Cardinalidad en Diagramas

```
┌────────────────────────────────────────────────────────┐
│             CARDINALIDAD DE RELACIONES                 │
├────────────────────────────────────────────────────────┤
│                                                        │
│  Relación 1:1 (Uno a Uno)                              │
│  ┌─────────┐        ┌─────────┐                       │
│  │   Auto  ├───[1]──[1]───┤Chasis│                    │
│  └─────────┘        └─────────┘                       │
│  Un Auto tiene exactamente un Chasis                  │
│                                                        │
│  Relación 1:N (Uno a Muchos)                           │
│  ┌─────────┐        ┌──────────┐                      │
│  │ Empresa ├───[1]──[*]───┤Employee│                  │
│  └─────────┘        └──────────┘                      │
│  Una Empresa tiene muchos Empleados                   │
│                                                        │
│  Relación N:N (Muchos a Muchos)                        │
│  ┌───────────┐      ┌──────────┐                      │
│  │ Developer ├──[*]──[*]──┤Project│                   │
│  └───────────┘      └──────────┘                      │
│  Muchos Developers trabajan en muchos Proyectos       │
│                                                        │
│  Simbología:                                           │
│  [1]  = Exactamente uno                               │
│  [*]  = Cero o más (muchos)                           │
│  [0..1] = Cero o uno                                  │
│  [1..*] = Uno o más                                   │
│                                                        │
└────────────────────────────────────────────────────────┘
```

---

## Matriz de Relaciones

```
┌──────────────────────────────────────────────────────┐
│         MATRIZ DE RELACIONES DEL MODELO              │
├──────────────┬──────────────┬──────────────────────────┤
│     De       │      A       │       Relación          │
├──────────────┼──────────────┼──────────────────────────┤
│ Developer    │ Persona      │ IS-A (herencia)         │
│ Tester       │ Persona      │ IS-A (herencia)         │
│ Persona      │ Direccion    │ HAS-A 1:1 (composición) │
│ Auto         │ Vehiculo     │ IS-A (herencia)         │
│ Auto         │ Chasis       │ HAS-A 1:1 (composición) │
│ Auto         │ Motor        │ HAS-A 1:1 (agregación)  │
│ Camioneta    │ Vehiculo     │ IS-A (herencia)         │
└──────────────┴──────────────┴──────────────────────────┘
```

---

## Notas para Diagramar

### Símbolos UML Comunes

- **Herencia**: Flecha triangular sólida apuntando a la clase base
- **Composición**: Diamante negro en el extremo del contenedor
- **Agregación**: Diamante blanco en el extremo del contenedor
- **Asociación**: Línea simple con posible cardinalidad

### Convenciones de Diagramas

- **Entidades abstractas**: Nombre en *cursiva* o con etiqueta `<<abstract>>`
- **Atributos privados**: Prefijo `-`
- **Atributos públicos**: Prefijo `+`
- **Métodos privados**: Prefijo `-`
- **Métodos públicos**: Prefijo `+`

---

**Próximo paso**: El usuario puede agregar sus propios diagramas dibujados a mano basándose en esta estructura.
