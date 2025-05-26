using System.Text.RegularExpressions;

Console.WriteLine("Ingerese una direccion web: ");
string direccionWeb = Console.ReadLine();

string patronWeb = @"\w+\.\w+\.\w";

if (Regex.IsMatch(direccionWeb, patronWeb))
{
    Console.WriteLine("La direccion ingresada es correcta");
}
else
{
    Console.WriteLine("No se encontro una pagina web con ese dominio");
}

Console.WriteLine("Ingerese una direccion web: ");
string email = Console.ReadLine();

string patronEmail = @"\w+@\w+\.\w";

if (Regex.IsMatch(email, patronEmail))
{
    Console.WriteLine("El e-mail ingresado es correcto");
}
else
{
    Console.WriteLine("No se encontro un e-mail coincidente");
}