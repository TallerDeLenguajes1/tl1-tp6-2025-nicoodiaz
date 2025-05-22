using System.Net.WebSockets;
using System.Timers;

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

double numACalcular;
Console.WriteLine("Ingrese un numero: ");
var pedirNumero = Console.ReadLine();
bool resultado2 = double.TryParse(pedirNumero, out numACalcular);

if (resultado2)
{
    Console.WriteLine($"El valor absoluto de {numACalcular} es {Math.Abs(numACalcular)}");
    Console.WriteLine($"El cuadrado de {numACalcular} es {Math.Pow(numACalcular, 2)}");
    Console.WriteLine($"La raiz cuadrada de {numACalcular} es {Math.Sqrt(Math.Abs(numACalcular))}");
    Console.WriteLine($"El seno de {numACalcular} es {Math.Sin(numACalcular)}");
    Console.WriteLine($"El coseno de {numACalcular} es {Math.Cos(numACalcular)}");
    Console.WriteLine($"La parte entera de {numACalcular} es {(int)numACalcular}");
}
else
{
    Console.WriteLine("No ingresaste un numero, intenta de nuevo");
}
double segundoNum;
Console.WriteLine("Ingrese otro numero:");
var pedirOtroNum = Console.ReadLine();
bool resultado2doNum = double.TryParse(pedirOtroNum, out segundoNum);

if (resultado2doNum && resultado2)
{
    Console.WriteLine($"El maximo entre {numACalcular} y {segundoNum} es {Math.Max(numACalcular, segundoNum)}");
    Console.WriteLine($"El minimo entre {numACalcular} y {segundoNum} es {Math.Min(numACalcular, segundoNum)}");
}
else
{
    Console.WriteLine("No ingreso un dato valido");
}