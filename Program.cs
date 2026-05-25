/*
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
*/

//EJERCICIO 1
/*Console.WriteLine("----EJERCICIO 1----");

Console.Write("Ingrese un Numero para invertirlo: ");
string numeroIngresado = Console.ReadLine();
int i = 0;

if(int.TryParse(numeroIngresado, out i))
{
    if(i <= 0)
    {
        Console.WriteLine("El numero ingresado no es mayor a 0");
    }
    else
    {
        int j;
        Console.Write("Numero Ingresado Invertido: ");
        for (j = (numeroIngresado.Length - 1); j >= 0; j--)
        {
            Console.Write($"{numeroIngresado[j]}");
        }
    }
}
else
{
    Console.WriteLine("La linea ingresada no es un numero");
}*/

//EJERCICIO 2
double num, num3, num4;

Console.WriteLine("CalculadoraV2");
Console.Write("Ingrese un numero: ");
while(!double.TryParse(Console.ReadLine(), out num))
{
    Console.Write("Lo ingresado no es un numero, intente denuevo: ");
}


Console.WriteLine("---------------------------");
Console.WriteLine($"Valor absoluto del numero ingresado: {Math.Abs(num)}");
Console.WriteLine($"Cuadrado del numero ingresado: {Math.Pow(num,2)}");
Console.WriteLine($"Raiz Cuadrada del numero ingresado: {Math.Sqrt(num)}");
Console.WriteLine($"Sen del numero ingresado: {Math.Sin(num)}");
Console.WriteLine($"Cos del numero ingresado: {Math.Cos(num)}");
Console.WriteLine($"Parte entera del numero ingresado: {Math.Truncate(num)}");
Console.WriteLine("---------------------------");


Console.Write("Ingrese un numero 1: ");
while(!double.TryParse(Console.ReadLine(), out num3))
{
    Console.Write("Lo ingresado no es un numero, intente denuevo: ");
}

Console.Write("Ingrese un numero 2: ");
while(!double.TryParse(Console.ReadLine(), out num4))
{
    Console.Write("Lo ingresado no es un numero, intente denuevo: ");
}

Console.WriteLine("---------------------------");
Console.WriteLine($"Maximo entre los dos numeros ingresados {Math.Max(num3,num4)}");
Console.WriteLine($"Minimo entre los dos numeros ingresados {Math.Min(num3,num4)}");
Console.WriteLine("---------------------------");