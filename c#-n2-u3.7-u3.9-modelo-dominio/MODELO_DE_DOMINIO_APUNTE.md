# MODELO DE DOMINIO - Apunte Teórico

## Introducción

Un **modelo de dominio** es una representación abstracta de los conceptos, entidades y relaciones
que existen en un problema específico del mundo real. Es una herramienta fundamental en el análisis
y diseño de software orientado a objetos.

## ¿Qué es el Modelo de Dominio?

El modelo de dominio es un **mapa conceptual** que representa:
- Las **entidades** (cosas, actores, conceptos) del problema
- Sus **atributos** (características, propiedades)
- Sus **comportamientos** (acciones, métodos)
- Las **relaciones** entre ellas

**Propósito**: Entender el problema ANTES de programar. Sirve como puente entre
el análisis del problema y la implementación en código.

## Componentes del Modelo de Dominio

### 1. **Entidades (Clases)**

Representan conceptos o cosas del mundo real que son relevantes para el problema.

**Ejemplo:**
- `Persona` - Un ser humano
- `Direccion` - Una ubicación
- `Developer` - Un desarrollador de software
- `Tester` - Un probador de software
- `Vehiculo` - Un medio de transporte
- `Auto` - Un automóvil específico

**Características de una buena entidad:**
- Tiene **identidad única** (se puede distinguir de otras)
- Tiene **atributos** (propiedades que la describen)
- Tiene **comportamientos** (acciones que realiza)
- Es **significativa** para el problema

### 2. **Atributos (Propiedades)**

Describen las características de una entidad. Son los datos que almacena.

**Ejemplo para `Persona`:**
- `Nombre` - Identificador textual
- `Telefono` - Medio de contacto
- `Direccion` - Ubicación (referencia a otra entidad)

**Ejemplo para `Direccion`:**
- `Calle` - Nombre de la vía
- `Ciudad` - Ciudad donde está
- `Provincia` - Región administrativa
- `CodigoPostal` - Código postal
- `Pais` - País

### 3. **Comportamientos (Métodos)**

Acciones que las entidades pueden realizar.

**Ejemplo para `Persona`:**
- `saludar()` - Acción de saludar

**Ejemplo para `Developer`:**
- `tirarUnHolaMundo()` - Escribir un programa básico

**Criterio de inclusión:**
- El método debe ser **significativo** para la entidad
- Debe representar acciones del **dominio**, no técnicas
- Debe responder: ¿Qué hace esta entidad en el mundo real?

## Relaciones entre Entidades

### Tipos de Relaciones

#### 1. **Herencia (IS-A)**

Una entidad **es un tipo específico** de otra entidad más general.

**Ejemplo:**
```
Persona (general)
├── Developer IS-A Persona
└── Tester IS-A Persona
```

**Características:**
- Relación **vertical** en la jerarquía
- El hijo **hereda** atributos y métodos del padre
- El hijo **puede agregar** nuevos atributos y comportamientos
- El hijo **puede especializar** el comportamiento

**En el dominio:**
- Developer **es un tipo de** Persona
- Tester **es un tipo de** Persona
- Ambos comparten características de Persona pero tienen especializaciones

#### 2. **Composición/Agregación (HAS-A)**

Una entidad **contiene** otra entidad.

**Ejemplo:**
```
Persona HAS-A Direccion
```

**Diferencia importante:**

**COMPOSICIÓN (HAS-A fuerte):**
- La entidad contenida es **parte integral**
- No puede existir **sin el contenedor**
- Si se elimina el padre, se elimina el hijo
- Ejemplo: Auto HAS-A Chasis

**AGREGACIÓN (HAS-A débil):**
- La entidad contenida es **independiente**
- Puede existir **sin el contenedor**
- Si se elimina el padre, el hijo **puede sobrevivir**
- Ejemplo: Auto HAS-A Motor (motor puede ser reemplazado)

### Cardinalidad de Relaciones

Describe **cuántos** elementos pueden participar en una relación:

- **1 a 1**: Una Persona tiene exactamente una Direccion principal
- **1 a N**: Una Persona puede tener múltiples Direcciones (actual, anterior, etc.)
- **N a N**: Desenvolvedores pueden trabajar en múltiples Proyectos y Proyectos tienen múltiples Developers

## Pasos para Identificar un Modelo de Dominio

### Paso 1: Identificar las Entidades Principales

**Pregunta clave:** ¿Qué cosas importantes existen en este problema?

**Método:**
- Leer la descripción del problema
- Identificar sustantivos principales
- Eliminar repeticiones y sinónimos

**Ejemplo del dominio estudiado:**
- Persona, Direccion, Developer, Tester, Vehiculo, Auto, Camioneta, Motor, Chasis

### Paso 2: Identificar Atributos

**Pregunta clave:** ¿Qué características describe a cada entidad?

**Método:**
- Por cada entidad, listar sus características
- Descartar características que son otras entidades
- Considerar el **tipo de dato**: string, int, double, bool, etc.

**Ejemplo:**
- `Persona.Nombre` (string)
- `Persona.Telefono` (string)
- `Persona.Direccion` (referencia a otra entidad)

### Paso 3: Identificar Comportamientos

**Pregunta clave:** ¿Qué acciones puede realizar esta entidad?

**Método:**
- Pensar en verbos relacionados con la entidad
- Mantener solo **comportamientos del dominio**
- No incluir métodos técnicos (getters, setters)

**Ejemplo:**
- `Persona.saludar()` ✓ (es del dominio)
- `Persona.ToString()` ✗ (es técnico)
- `Developer.tirarUnHolaMundo()` ✓ (es del dominio)

### Paso 4: Identificar Relaciones

**Pregunta clave:** ¿Cómo se relacionan estas entidades?

**Método:**
- Por cada par de entidades, preguntarse: ¿Se relacionan?
- Determinar el tipo: Herencia, Composición o Agregación
- Establecer la cardinalidad (1-1, 1-N, N-N)

**Ejemplo:**
- Persona → Direccion: HAS-A (Composición)
- Developer → Persona: IS-A (Herencia)
- Auto → Motor: HAS-A (Agregación)

## Beneficios de un Buen Modelo de Dominio

### 1. **Comunicación**
- Facilita la comunicación entre el equipo y los clientes
- Usa lenguaje del dominio, no términos técnicos

### 2. **Claridad**
- Define claramente qué debe hacer el software
- Reduce la ambigüedad

### 3. **Estructura**
- Guía la estructura del código
- Facilita la mantenibilidad

### 4. **Validación**
- Permite validar que se entiende correctamente el problema
- Antes de invertir tiempo en programación

### 5. **Extensibilidad**
- Facilita agregar nuevas funcionalidades
- La estructura está bien establecida

## Relación entre Modelo de Dominio y Código

### Del Dominio al Código

**Modelo de Dominio** → **Código**

```
Entidad              →  Clase
Atributo             →  Propiedad/Campo
Comportamiento       →  Método
Herencia             →  `: ClaseBase`
Composición          →  `public Clase propiedad { get; set; }`
Agregación           →  `public Clase propiedad { get; set; }`
```

### Características del Mapeo

- **Directo**: Generalmente es 1:1
- **Reversible**: Debe ser fácil volver del código al modelo
- **Consistente**: Mismos nombres, mismas relaciones

## Principios de Diseño en el Modelo de Dominio

### 1. **Separación de Responsabilidades**

Cada entidad debe tener una **responsabilidad única y clara**.

**Bien:**
- `Persona` maneja datos de la persona
- `Direccion` maneja datos de ubicación

**Mal:**
- `Persona` también gestiona persistencia en BD

### 2. **Cohesión Alta**

Los elementos relacionados deben estar **juntos**.

**Bien:**
- `Auto` contiene `Motor` y `Chasis`

**Mal:**
- `Motor` en una clase y `Chasis` en otra sin relación

### 3. **Acoplamiento Bajo**

Las dependencias entre entidades deben ser **mínimas**.

**Bien:**
- `Auto` referencia `Motor` (agregación débil)

**Mal:**
- `Auto` está fuertemente acoplado a `GasolineraManager`, `PolizaSeguro`, etc.

### 4. **Nomenclatura Clara**

Los nombres deben **reflejar el dominio**.

**Bien:**
- `Developer.tirarUnHolaMundo()` - Ubique al desarrollador que no entiende programación

**Mal:**
- `Persona.metodo1()` - Sin significado

## Ejemplo Integrador: Modelo de Dominio Empresa Tecnológica

### Entidades Identificadas:

**Persona (abstracta)**
- Atributos: Nombre, Telefono, Direccion
- Comportamiento: saludar()

**Developer (hereda de Persona)**
- Atributos adicionales: Lenguajes, Seniority
- Comportamiento: tirarUnHolaMundo()

**Tester (hereda de Persona)**
- Atributos adicionales: NivelEstress

**Direccion (compo/agregación de Persona)**
- Atributos: Calle, Ciudad, Provincia, CodigoPostal, Pais

### Relaciones:

```
Persona (base)
├─ Developer IS-A Persona
└─ Tester IS-A Persona

Persona HAS-A Direccion (Composición)
```

## Errores Comunes al Modelar

### ❌ 1. Incluir Detalles de Implementación

**Incorrecto:**
- `Usuario.IdBD` - Es técnico
- `Persona.ArrayList<Direcciones>` - Mezcla dominio con técnica

**Correcto:**
- `Persona.Direcciones` - Solo el concepto

### ❌ 2. Omitir Conceptos Importantes

**Incorrecto:**
- Olvidar que `Direccion` es una entidad separada
- Incluir dirección como string en `Persona`

**Correcto:**
- Identificar `Direccion` como entidad propia

### ❌ 3. Sobre-ingeniería

**Incorrecto:**
- Agregar entidades que no son relevantes
- Crear jerarquías profundas innecesarias

**Correcto:**
- Mantener simplicidad
- Solo incluir lo necesario

### ❌ 4. Ignorar las Relaciones

**Incorrecto:**
- Crear entidades pero no documentar cómo se relacionan

**Correcto:**
- Dibujar explícitamente las relaciones
- Indicar cardinalidad

## Herramientas para Representar el Modelo

### 1. **Diagrama UML (Unified Modeling Language)**

- Estándar de la industria
- Usa notación visual clara
- Fácil de comunicar

### 2. **Diagramas a Mano**

- Flexible y rápido
- Ideal para sesiones de análisis
- No requiere herramientas

### 3. **Pseudocódigo**

- Describe la estructura en lenguaje cercano a la programación
- Fácil de traducir a código real

## Conclusión

El modelo de dominio es el **fundamento de un buen diseño de software**.

**Recordar:**
1. Identifica las **entidades del problema**, no las del código
2. Define **atributos y comportamientos** significativos
3. Establece **relaciones claras** (herencia, composición, agregación)
4. Valida con el **dominio del problema**
5. Usa como **guía para la implementación**

**Un modelo de dominio bien diseñado resulta en código:**
- **Mantenible**: Fácil de entender y modificar
- **Extensible**: Fácil de agregar nuevas funcionalidades
- **Robusto**: Menos propenso a errores de lógica
- **Profesional**: Refleja entendimiento real del problema
