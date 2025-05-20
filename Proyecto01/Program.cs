using System.Net.WebSockets;

int a;
int b;

a = 10;
b = a;
Console.WriteLine($"Valor de a {a}");
Console.WriteLine($"Valor de b {b}");

int numIngresado;
Console.WriteLine("Ingrese un numero: ");
var numeroPedido = Console.ReadLine();//Leo el numero
bool resultado = int.TryParse(numeroPedido, out numIngresado);//Para ver que si se haya podido convertir correctamente
if (resultado && numIngresado > 0)//Si resultado es "true" y es > 0, entonces lo ejecuto
{
    int numOriginal = numIngresado;
    int numeroComodin = 0; //Variable para guardar el num invertido
    while (numIngresado != 0)
    {
        int ultNumero = numIngresado % 10;//Obtengo el ultimo digito al numero ingresado
        numeroComodin = numeroComodin * 10 + ultNumero;//Lo guardo en el comodin
        numIngresado = numIngresado / 10;//Le saco el ultimo digito al numero ingresado
    }
    Console.WriteLine($"El numero ingresado es: {numOriginal}, y el numero invertido es {numeroComodin}");
}
else
{
    Console.WriteLine("Lo que ingreso no es un numero, o es menor o igual que cero");
}