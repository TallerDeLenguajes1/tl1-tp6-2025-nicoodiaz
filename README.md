[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)


## ¿String es un tipo por valor o un tipo por referencia?

Aunque se usa como si fuera un valor (porque no se puede cambiar una vez creado), `string` en realidad es un **tipo por referencia**. O sea, cuando lo pasás a una función, se pasa la "dirección" donde está guardado, no una copia. Pero como es inmutable (no se puede modificar directamente), parece que se comporta como un valor.

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape son combinaciones especiales que se usan con el `\` para representar cosas como saltos de línea o comillas. Algunas de las más usadas son:

- `\n` -> Salto de linea.
- `\t` -> Tabulacion.
- `\\` -> Barra invertida.
- `\"` -> Comilla doble, sirve para dentro de una cadena de texto poder ponerla
- `\r` -> Retorno de carro.
- `\a` -> Sonido de alerta
- `\b` -> Retroceso.

## ¿Que  sucede cuando utilizo  el carácter @ y $ antes de una cadena   de texto?

- **@** antes de un string hace que se lea literalmente. es decir, ignora las secuencias de escape. También sirve para escribir rutas de archivos (paths) sin tener que usar doble barra.
Ejemplo: @"C:\Usuarios\Nombre"

- **$** sirve para insertar variables dentro del string de una forma mas  fácil, sin tener que usar `+`.
Ejemplo: string nombre = "Juan"; ____ Console.WriteLine($"Hola, {nombre}");