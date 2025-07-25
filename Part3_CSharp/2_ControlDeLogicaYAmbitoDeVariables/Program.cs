using System.Reflection.Metadata;

Console.Clear();

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Parte 3: Introducción a C#");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("2_Control de Lógica y Ámbito de Variables");
Console.WriteLine("-----------------------------------------\n");

// -------------------------------------------------
// Unidad 2_Bloques de código y ambito de variables
// -------------------------------------------------
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Unidad 2: Bloques de código y ámbito de variables");
Console.WriteLine("--------------------------------------------------\n");

// Variable global
bool flag = true;

// int value = 10; // Si movieramos la linea del bloque if hacia el ambito global, quitandola de del bloque if, podriamos ver que 'value' se define en el ambito global y se puede usar en cualquier parte del programa.

if (flag)
{
    // Variable local
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}"); // Aquí 'value' está definido dentro del bloque if y se puede usar sin problemas.
}

// Console.WriteLine($"Outside the code block: {value}"); // En este caso, esto causaria un error de compilacion porque 'value' no está definido en este contexto (externo al if).

// -------------------------------------------------
// Unidad 3_Eliminacion de bloques de codigo
// -------------------------------------------------
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("Unidad 3: Eliminacion de bloques de codigo");
Console.WriteLine("--------------------------------------------------\n");

bool flag2 = true;
if (flag2)
    Console.WriteLine(flag2); // C# permite omitir las llaves si el bloque de código contiene una sola instrucción. Esto es útil para simplificar el código, pero no debemos sacrificar la legibilidad.

/*
C# admite escribir codigo como esta a continuacion, pero no es recomendable por temas de legibilidad.

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/

// Este codigo a continuación es una forma mas legible de escribir el codigo anterior, ya que se usan las llaves para definir los bloques de codigo.
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

// -------------------------------------------------
// Unidad 4_Actividad desafío de ambito de variables
// -------------------------------------------------
Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine("Unidad 4: Actividad desafío de ambito de variables");
Console.WriteLine("--------------------------------------------------\n");

/* Codigo original con errores de ambito de variables
Consigna: Corregir el siguiente código para que funcione correctamente, evitando errores de ámbito de variables.

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/

// Codigo corregido para evitar errores de ambito de variables
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
    {
        found = true;
    }
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

// -------------------------------------------------
// Fin del programa
// -------------------------------------------------
Console.WriteLine("\n\nPulse alguna tecla para continuar...");
Console.ReadKey();
