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
int opcion, num1, num2;
int reintentar = 1;

while(reintentar == 1)
{
    Console.WriteLine("----Calculadora V1----");
    Console.WriteLine("Opcion 1: SUMAR");
    Console.WriteLine("Opcion 2: RESTAR");
    Console.WriteLine("Opcion 3: MULTIPLICAR");
    Console.WriteLine("Opcion 4: DIVIDIR");
    Console.Write("Elija una opcion: ");
    int.TryParse(Console.ReadLine(), out opcion);

    while(opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4)
    {
        Console.WriteLine("------------------------------");
        Console.Write("error, ingrese la opcion denuevo: ");
        int.TryParse(Console.ReadLine(), out opcion);
    }

    Console.Write("Ingrese un numero 1: ");
    int.TryParse(Console.ReadLine(), out num1);

    Console.Write("Ingrese un numero 2: ");
    int.TryParse(Console.ReadLine(), out num2);

    switch (opcion)
    {
        case 1:
        Console.WriteLine($"SUMA DE NUM1 Y NUM 2: {num1+num2}");
        break;

        case 2:
        Console.WriteLine($"RESTA DE NUM1 Y NUM 2: {num1-num2}");
        break;

        case 3:
        Console.WriteLine($"MULTIPLICACION DE NUM1 Y NUM 2: {num1*num2}");
        break;

        case 4:
        Console.WriteLine($"DIVISION DE NUM1 Y NUM 2: {num1/num2}");
        break; 
    }

    Console.WriteLine("Desea realizar otra operacion?");
    Console.WriteLine("Opcion 1: SI");
    Console.WriteLine("Opcion 2: NO");
    Console.Write("Seleccione: ");
    int.TryParse(Console.ReadLine(), out reintentar);
    while(reintentar != 1 && reintentar != 2)
    {
        Console.WriteLine("------------------------------");
        Console.Write("error, ingrese la opcion denuevo: ");
        int.TryParse(Console.ReadLine(), out reintentar);
    } 
}

