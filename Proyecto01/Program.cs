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

//Ejercicio 2
int opcion = 0;
do
{
    Console.WriteLine("Elija una opcion para seleccionar la operacion: ");
    Console.WriteLine("1. Sumar dos numeros");
    Console.WriteLine("2. Restar dos numeros");
    Console.WriteLine("3. Multiplicar dos numeros");
    Console.WriteLine("4. Dividir dos numeros");
    Console.WriteLine("5. Salir");
    var pedirOpcion = Console.ReadLine();
    bool resultadoOpcion = int.TryParse(pedirOpcion, out opcion);
    if (resultadoOpcion && opcion > 0 && opcion < 6)
    {
        switch (opcion)
        {
            case 1:
                double numSuma1 = PedirDatosPrimerNum();
                double numSuma2 = PedirDatosSegundoNum();
                Sumar(numSuma1, numSuma2);
                break;
            case 2:
                double numResta1 = PedirDatosPrimerNum();
                double numResta2 = PedirDatosSegundoNum();
                Restar(numResta1, numResta2);
                break;
            case 3:
                double numMulti1 = PedirDatosPrimerNum();
                double numMulti2 = PedirDatosSegundoNum();
                Multiplicar(numMulti1, numMulti2);
                break;
            case 4:
                double numDiv1 = PedirDatosPrimerNum();
                double numDiv2 = PedirDatosSegundoNum();
                Dividir(numDiv1, numDiv2);
                break;
        }
    }
    else
    {
        Console.WriteLine("No ingreso una opcion valida");
    }

} while (opcion != 5);

double PedirDatosPrimerNum()
{
    double PrimerNum = 0;
    Console.WriteLine("Ingrese el primer numero: ");
    var num1 = Console.ReadLine();
    bool resultado = double.TryParse(num1, out PrimerNum);
    if (resultado) return PrimerNum;
    return 0;
}
double PedirDatosSegundoNum()
{
    double SegundoNum = 0;
    Console.WriteLine("Ingrese el segundo numero: ");
    var num2 = Console.ReadLine();
    bool resultado = double.TryParse(num2, out SegundoNum);
    if (resultado) return SegundoNum;
    return 0;
}

void Sumar(double a, double b)
{
    Console.WriteLine($"La suma entre {a} y {b} es {a + b}");
}

void Restar(double a, double b)
{
    Console.WriteLine($"La suma entre {a} y {b} es {a - b}");
}

void Multiplicar(double a, double b)
{
    Console.WriteLine($"La suma entre {a} y {b} es {a * b}");
}
void Dividir(double a, double b)
{
    Console.WriteLine($"La suma entre {a} y {b} es {a / b}");
}