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

//EJECICIO 3
double num, num3, num4;

Console.WriteLine("----CalculadoraV2----");
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

//EJERCICIO 4
Console.Write("Ingrese una cadena: ");
string s = Console.ReadLine();

Console.WriteLine($"Longitud de la cadena: {s.Length}");

Console.Write("Ingrese una segunda cadena para concatenar con la primera: ");
string s1 = Console.ReadLine();

Console.WriteLine($"Cadena 1 concatenada con la Cadena 2: {s}{s1}");

Console.WriteLine($"Subcadena de Cadena 1: {s.Substring(0,2)}");

int numero1, numero2, resultado;
Console.Write("Ingrese un numero1: ");
while(!int.TryParse(Console.ReadLine(), out numero1))
{
    Console.Write("Lo ingresado no es un numero, intente denuevo: ");
}
Console.Write("Ingrese un numero2: ");
while(!int.TryParse(Console.ReadLine(), out numero2))
{
    Console.Write("Lo ingresado no es un numero, intente denuevo: ");
}

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

    switch (opcion)
    {
        case 1:
        resultado = numero1 + numero2;
        Console.WriteLine("La suma entre "+ numero1.ToString() +" y "+ numero2.ToString() +" es igual a: "+ resultado.ToString() );
        break;

        case 2:
        resultado = numero1 - numero2;
        Console.WriteLine("La resta entre "+ numero1.ToString() +" y "+ numero2.ToString() +" es igual a: "+ resultado.ToString() );
        break;

        case 3:
        resultado = numero1 * numero2;
        Console.WriteLine("La Multiplicacion entre "+ numero1.ToString() +" y "+ numero2.ToString() +" es igual a: "+ resultado.ToString() );
        break;

        case 4:
        resultado = numero1 / numero2;
        Console.WriteLine("La division entre "+ numero1.ToString() +" y "+ numero2.ToString() +" es igual a: "+ resultado.ToString() );
        break;
    }

Console.WriteLine("Cadena 1 recorrida con for each: ");
foreach(char caracter in s)
{
    Console.WriteLine(caracter);
}


Console.WriteLine("Ingrese una subcadena para buscar su ocurrecia en Cadena 1: ");
string s2 = Console.ReadLine();

if(s.IndexOf(s2) != -1)
{
    Console.WriteLine("La subcadena "+ s2 + ", SI se encuentra en la Cadena 1");
}
else
{
    Console.WriteLine("La subcadena "+ s2 + ", NO se encuentra en la Cadena 1");
}

Console.WriteLine($"La cadena 1 en mayusculas es: {s.ToUpper()}");
Console.WriteLine($"La cadena 1 en minusculas es: {s.ToLower()}");


Console.WriteLine("Ingrese una cadena separada que este separada por un caracter especifico: ");
string s3 = Console.ReadLine();

Console.WriteLine("Ingrese el caracter: ");
char caracterEspeficico = Console.ReadLine()[0];

foreach(string palabra in s3.Split(caracterEspeficico))
{
    Console.WriteLine(palabra);
}


Console.WriteLine("Ingrese una ecuacion simple: ");
string ecuacion = Console.ReadLine();
int resultadoEcuacion = 0;

if(ecuacion.IndexOf("+") != -1)
{
    string[] terminos = ecuacion.Split('+');
    resultadoEcuacion = int.Parse(terminos[0]) + int.Parse(terminos[1]);
}
if(ecuacion.IndexOf("-") != -1)
{
    string[] terminos = ecuacion.Split('-');
    resultadoEcuacion = int.Parse(terminos[0]) - int.Parse(terminos[1]);
}
if(ecuacion.IndexOf("*") != -1)
{
    string[] terminos = ecuacion.Split('*');
    resultadoEcuacion = int.Parse(terminos[0]) * int.Parse(terminos[1]);
}
if(ecuacion.IndexOf("/") != -1)
{
    string[] terminos = ecuacion.Split('/');
    resultadoEcuacion = int.Parse(terminos[0]) / int.Parse(terminos[1]);
}

Console.WriteLine("Resultado de la ecuacion: "+ resultadoEcuacion);

