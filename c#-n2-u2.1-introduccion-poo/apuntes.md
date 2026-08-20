# Introducción a la programación orientada a objetos

Apunte del video `c#-n2-u2.1-introduccion-poo` (clase teórica, sin código).

---

## Qué es la POO

La programación orientada a objetos es un **paradigma de programación**.

Un paradigma es una forma de hacer las cosas: un concepto, una manera de ver un modelo. En este caso, un modelo de programación.

## Paradigmas que ya conocemos (y otros)

Existen muchos paradigmas. Los más conocidos, según la clase:

- **Programación estructurada**: es con la que generalmente se aprende a programar. Incluye programación **imperativa**: instrucciones una debajo de la otra hasta llegar a un resultado. Lo máximo que se hace es **modularizar** esas instrucciones en funciones que se llaman entre sí. Es lo visto en el Nivel 1.
- **Programación orientada a objetos**: el paradigma de trabajo “de todos los tiempos” para construir aplicaciones.
- También se mencionan, sin desarrollar: lenguajes de cuarta generación, programación funcional, y otros que van apareciendo.

## Cambia la forma de pensar

La POO **cambia radicalmente la forma de pensar**.

Ya no se trata de resolver un problema con una serie de instrucciones de arriba hacia abajo. Hay que pensar el mundo digital de forma más amplia.

La premisa del curso (también en el Nivel 1) no es “archivo nuevo, proyecto, y a escribir código a ver qué pasa”. El camino es:

1. Analizar lo que piden.
2. Tomar notas y ajustar.
3. Hacer un bosquejo o diagrama.
4. Recién después llevarlo a código.

En POO eso se potencia: se abordan **sistemas y aplicaciones reales**, no solo ejercicios de sumar, dividir o multiplicar. Pueden ser apps chicas, medianas o grandes, con una visión de producto que **crece** (más funcionalidades con el tiempo).

Eso se relaciona con una aplicación **escalable**. La escalabilidad aparece como **consecuencia** de un buen análisis inicial y de una buena arquitectura inicial; no es un truco que se agrega al final.

## No es un solo bloque de código

En estructurada, hay un bloque que se ejecuta de arriba abajo y el programa termina.

En POO hay bloques de código en varios lados. No son simplemente funciones que se llaman entre sí de forma lineal: interactúan de una manera particular, que depende del contexto de lo que se está construyendo. Eso se va a ir viendo de a poco.

## Conceptos que van a aparecer en el curso

Para arrancar:

- clase
- objeto
- información
- comportamiento
- métodos
- propiedades
- atributos

Más adelante:

- herencia
- asociación (se aclara que **mucho no se menciona**, aunque es importante)
- polimorfismo
- sobreescritura
- sobrecarga
- interfaces

Al comenzar, los temas principales son: **clases, objetos, herencia y asociación**.

Hay que ir amoldando la mente de a poco. No hace falta incorporar todo de una.

## Reutilizar código no es el objetivo

Una de las cosas que “se venden” de la POO es reutilizar código y escribir menos.

En esta clase se marca otra postura: la reutilización **está** en el paradigma, pero **no es lo que hay que ir a buscar**. Es una **consecuencia** de aprender bien POO y de construir buenos modelos de aplicación.

Lo que propone el paradigma es poder abordar problemáticas más amplias, con más alcance, y distintas propuestas para distintos escenarios.

## Representar la realidad en lo digital

Característica central: **representar la realidad que nos rodea en lo digital**.

A partir de esos modelos se administra la información dentro de las aplicaciones.

## Qué es una clase

En POO, **todo es una clase**. Es el primer concepto a entender.

Definiciones que aparecen en manuales (todas válidas a nivel técnico):

- plantilla
- esqueleto
- estructura
- modelo
- estructura o mapa de un objeto

La definición que se prioriza en la clase:

> **Crear una clase = crear un nuevo tipo de dato.**

Ya conocemos tipos elementales (`int`, `float`, `char`, `string`). Cada uno tiene características y una finalidad. Cuando hay que manipular cosas más complejas, la clase permite definir **nuestro propio tipo**.

### Relación con las estructuras (`struct`)

Hay un concepto anterior llamado **estructura**, que también permite crear un tipo de dato propio. Casi no se usa, pero sirve de puntapié.

Diferencia:

| Estructura | Clase |
| --- | --- |
| Permite un tipo de dato propio | También permite un tipo de dato propio |
| Orientada a datos | Evolución: datos **y comportamiento** |

Hay un video en el curso de fundamentos (gratis) que explica estructuras con diagramas.

### Clase y realidad

Al definir una clase se escribe un bloque que define la forma de algo: el tipo de dato que se quiere representar.

Ese “algo” es un recorte de la **realidad**: se diseña en lo digital para poder manipularlo en las aplicaciones.

Ejemplos clásicos de clases: **Persona**, **Empleado**, **Auto**.

## De registros sueltos a un tipo de dato

Hasta ahora (Nivel 1 / ejercicios con vectores) se manejaban **registros** con variables independientes (4 o 5 variables) y, como mucho, varios vectores en paralelo.

Ejemplos de esos registros: ventas, empleados, alumnos, autos.

En POO esa información se agrupa en **una sola clase**. Ya no se manejan los datos por separado: se construye un tipo de dato a partir de un análisis.

Cómo se diseña:

1. Análisis preliminar: qué objeto de la realidad quiero representar.
2. Bosquejo / diseño (no saltar directo a código, salvo para practicar).
3. Recién después, codificación.

En general no se diseña una sola clase aislada: se bosqueja el conjunto y después se lleva a código.

## Ejemplo de análisis: Botella

Escenario imaginado: una aplicación que gestione plásticos de una empresa de botellas.

La clase se llama **Botella** porque se modela ese objeto de la realidad.

Características posibles (van a ser **atributos**):

- tamaño
- altura
- ancho
- material (plástico, vidrio, metal, etc.)
- cantidad de líquido que admite
- qué líquido admite
- color
- marca
- materiales complementarios

Con esa clase se pueden tener **distintas variables de tipo Botella**, cada una con sus valores:

- una botella celeste con agua
- una botella negra con Fernet
- una botella azul con cerveza

## Clase vs objeto (variable)

Cuando la clase está definida, a partir de ella se generan **objetos** (también dichos como variables de ese tipo).

Si hay tres botellas físicas, se pueden representar con la misma clase:

- tipo de dato Botella, botella uno
- tipo de dato Botella, botella dos
- tipo de dato Botella, botella tres

A cada una se le cargan sus características (color, material, líquido, etc.) por separado.

Analogía con tipos que ya conocemos:

- tres `int`: número1, número2, número3, cada uno con un número distinto
- tres `char`: letra1, letra2, letra3, cada una con una letra distinta

Es la misma idea, un poco más compleja.

Los conceptos (clase, objeto, atributo, etc.) están muy acoplados y a veces cuesta separarlos. Se van a volver a ver cuando se lleven a código.

## Qué no hay en este video

No se abre Visual Studio ni se escribe C#. El docente dice explícitamente que el tema es teórico e imaginativo, y que **el código queda para la próxima clase**.

## Para llevarse

- POO es un paradigma: otra forma de modelar programas.
- Primero se analiza y se diseña; después se codea.
- Una clase es un **nuevo tipo de dato** que representa algo de la realidad (datos + comportamiento).
- Un objeto es una instancia / variable de esa clase.
- Las características del objeto se convierten en **atributos**.
- Reutilizar código es consecuencia de un buen modelo, no el objetivo.
- El ejemplo disparador de las clases siguientes es **Botella**.
