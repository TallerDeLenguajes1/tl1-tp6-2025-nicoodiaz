Console.WriteLine("Ingrese una cadena de texto: ");

var cadenaDeTexto = Console.ReadLine();

int largoCadena = cadenaDeTexto.Length;
Console.WriteLine($"El largo de la cadena de texto es: {largoCadena}");

Console.WriteLine("Ingrese una segunda cadena de texto: ");
var cadenaDeTexto2 = Console.ReadLine();

//Unir ambas cadenas
var cadenasUnidas = cadenaDeTexto + " " + cadenaDeTexto2;
//Para poder extraer una subcadena de texto
if (cadenaDeTexto.Length >= 5)
{
    string cadenaExtraida = cadenaDeTexto.Substring(0, 5);
    Console.WriteLine($"La cadena extraida es: {cadenaExtraida}");
}
else
{
    Console.WriteLine("La cadena es demasiado corta, por favor ingrese otra.");
}

//Mostrar elemento por elemento la cadena de texto
foreach (var item in cadenaDeTexto)
{
    Console.WriteLine(item);
}

//Para poder buscar una palabra en cualquiera de las dos cadenas ingresadas
Console.WriteLine("Ingrese una palabra para buscar en la cadena ingresada anteoriormente: ");
var palabraABuscar = Console.ReadLine();

if (cadenaDeTexto.Contains(palabraABuscar) || cadenaDeTexto2.Contains(palabraABuscar))
{
    Console.WriteLine($"La palabra {palabraABuscar}, si aparece en una de las dos cadenas ingresadas");
}
else
{
    Console.WriteLine("La palabra ingresada no figura en ninguna de las dos cadenas");
}

//Convertir la cadena en mayuscula y minuscula respectivamente
string cadenaMayuscula = cadenaDeTexto.ToUpper();
string cadenaMinuscula = cadenaDeTexto.ToLower();
Console.WriteLine($"La cadena en mayusculas {cadenaMayuscula}. \n La cadena en minuscula {cadenaMinuscula}");

//Ingresar cadena separada por caracteres.

Console.WriteLine("Ingrese una cadena de texto separada por un caracter: ");

var cadenaConcaracteres = Console.ReadLine();

Console.WriteLine("Ingrese el caracter con el que separo la cadena: ");

var separador = Console.ReadLine();

//Separo la cadena y la guardo en un array, string[] pero declarado como var
var partesDeLaCadena = cadenaConcaracteres.Split(separador);

Console.WriteLine("Las partes de la cadena son: ");
foreach (var item in partesDeLaCadena)
{
    Console.WriteLine(item);
}