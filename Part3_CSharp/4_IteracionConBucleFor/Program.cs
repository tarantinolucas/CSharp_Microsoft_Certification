using System.Reflection.Metadata;

Console.Clear();

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Parte 3: Introducción a C#");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("4_Iteración con Bucle For");
Console.WriteLine("-----------------------------------------\n");

// -------------------------------------------------
// Unidad 2_Implementacion de una instruccion switch
// -------------------------------------------------
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Unidad 2: Creación y configuración de un bucle for");
Console.WriteLine("--------------------------------------------------\n");

// Escritura de una instruccion basica
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i}{(i < 9 ? "-" : "")}");
}

Console.WriteLine("\n");

// Cambiamos las condiciones de iteración
for (int i = 10; i >= 0; i--)
{
    Console.Write($"{i}{(i > 0 ? "-" : "")}");
}

Console.WriteLine("\n");

// Experimentando con el patron iterador
for (int i = 0; i < 10; i += 3)
{
    Console.Write($"{i}{(i < 9 ? "-" : "")}");
}

Console.WriteLine("\n");

// Usando la palabra clase break para interrumpir la instruccion de iteración
for (int i = 0; i < 10; i++)
{
    Console.Write($"{i}{(i < 7 ? "-" : "")}");
    if (i == 7)
        break;
}

Console.WriteLine("\n");

// Recorrido en bucle de todos los elementos de una matriz
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("\n");

// Examen de la limitación de la instrucción foreach
string[] names2 = { "Alex", "Eddie", "David", "Michael" };
foreach (string name in names2)
{
    // No se puede hacer esto ya que causa un error de compilación:
    /*
    if (name == "David")
        name = "Sammy";
    */
}

// Superación de la limitación de la instrucción foreach mediante un bucle for
string[] names3 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names3.Length; i++)
{
    if (names3[i] == "David")
        names3[i] = "Sammy";
}

foreach (var name in names3)
{
    Console.WriteLine(name);
}

// Unidad 3: Realización de una actividad desafio con instrucciones for e if
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("Unidad 3: Desafío FizzBuzz con instrucciones for e if");
Console.WriteLine("--------------------------------------------------\n");

/*
Desafío FizzBuzz:

Desafío de código: Implementación de las reglas de desafío de FizzBuzz
Estas son las reglas de FizzBuzz que necesita implementar en el proyecto de código:

Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
*/

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}

// -------------------------------------------------
// Fin del programa
// -------------------------------------------------
Console.WriteLine("\n\nPulse alguna tecla para continuar...");
Console.ReadKey();
