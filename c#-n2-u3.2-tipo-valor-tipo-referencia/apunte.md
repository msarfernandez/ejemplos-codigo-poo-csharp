# c#-n2-u3.2-tipo-valor-tipo-referencia — Apunte

## Sobre este video

A diferencia del video anterior, **acá no hay ninguna sesión de Visual Studio ni
archivos de código editándose en pantalla**. Es un video íntegramente conceptual:
el presentador habla a cámara y se superponen textos y diagramas animados
(recuadros con flechas) para explicar el comportamiento de las **variables de
tipo referencia** en C#.

No se ve en pantalla ningún ejemplo de **tipo por valor** (a pesar de que el
título del video lo menciona) — probablemente se explica solo de forma verbal,
sin gráficos, por lo que no hay nada transcribible de esa parte.

## Secuencia de conceptos mostrados

1. **Declaración de una referencia**
   Texto en pantalla: `Vehiculo v1;`
   (reutiliza el nombre de clase `Vehiculo` del video anterior de herencia).

2. **Concepto de Common Runtime Language (CLR)**
   Texto en pantalla: "Common Runtime Language" — mencionado como el entorno de
   ejecución de .NET que administra los objetos en memoria.

3. **Una variable de referencia apuntando a un objeto**
   Diagrama: dos recuadros, `v1` y `obj1`, primero separados y luego unidos por
   una flecha: `v1 → obj1`. Ilustra que `v1` no contiene el objeto en sí, sino
   una referencia a él.

4. **Referencia nula**
   Diagrama: `v1 → NULL` (la flecha ahora apunta a `NULL` en vez de a `obj1`).

5. **NullReferenceException**
   Texto en pantalla: "NullReferenceException" — consecuencia de intentar usar
   una referencia que vale `null`.

6. **Reasignar una referencia a otro objeto**
   Diagrama: aparecen `obj1` y `obj2` como dos objetos distintos. Se muestra
   `v1` con una flecha hacia `obj1` y otra hacia `obj2` simultáneamente, con una
   **X roja** marcando el cruce entre ambas flechas, y termina con `v1 → obj2`
   solamente. Ilustra que al reasignar una variable de referencia a un nuevo
   objeto, esta deja de apuntar al anterior (la flecha vieja se "rompe").

7. **Dos variables referenciando el mismo objeto**
   Texto en pantalla: `Vehiculo v2;`
   Diagrama: `v1 → obj1` y `v2 → obj1` (ambas flechas apuntan al mismo recuadro
   `obj1`).

8. **Igualdad de identidad**
   Texto en pantalla (recuadro de explicación):
   > "Y acá es donde podemos observar el concepto de igualdad en la identidad:
   > v1 es idéntico a v2, pues son el mismo objeto."

## Tecnologías / temas mencionados

- C# — tipos por referencia (`class`), variables de referencia, `null`,
  `NullReferenceException`.
- CLR (Common Runtime Language, mencionado así en pantalla — el nombre técnico
  correcto es *Common Language Runtime*, pero se transcribe tal como aparece
  en el video).
- Concepto de igualdad de identidad (`==` entre referencias que apuntan al
  mismo objeto).

## Nota

No se generó un proyecto de código para este video porque no hay código real
mostrado en pantalla (ni archivos, ni un editor, ni una terminal): todo el
contenido son textos y diagramas ilustrativos superpuestos sobre la cámara.
