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

# Ejercicio 5 - Respuestas

## ¿Qué son y cómo funcionan las expresiones regulares?

Las expresiones regulares, son como una especie de "patrón" que se usa para **buscar o verificar texto**
Por ejemplo, se pueden  buscar cosas como:
- Si un texto solo contiene numeros.
- Si una palabra empieza con mayuscula.
- Si un email tiene el formato correcto.

## ¿Funcionan unicamente en C#?

No, tambien funionan en otros lenguajes como:
- Python.
- Java.
- JavaScript.
- PHP.

## ¿En qué casos le parecen utiles? Enuncie al menos 3.

Se pueden utilizar por ejemplo para poder verificar si un usuario escribió bien su correo, para poder validar una contraseña o para buscar un dato especifico en una cadena de texto muy larga.

## ¿Cómo se hace uso de estas en C#?

Se debe usar la clase **Regex** que viene del namespace **System.Text.RegularExpressions**. Un ejemplo:

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string texto = "Mi email es usuario@example.com";
        string patron = @"\w+@\w+\.\w+"; // patrón para un email

        if (Regex.IsMatch(texto, patron))
        {
            Console.WriteLine("Se encontró un email en el texto.");
        }
        else
        {
            Console.WriteLine("No se encontró ningún email.");
        }
    }
}
