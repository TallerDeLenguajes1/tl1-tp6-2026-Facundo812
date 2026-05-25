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
Console.WriteLine("----EJERCICIO 1----");

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
}

//EJERCICIO 2

