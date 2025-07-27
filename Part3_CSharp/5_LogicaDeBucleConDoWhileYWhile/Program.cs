using System.Reflection.Metadata;

Console.Clear();

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Parte 3: Introducción a C#");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("5_Lógica de Bucle con Do While y While");
Console.WriteLine("-----------------------------------------\n");

// -------------------------------------------------
// Unidad 5_Lógica de Bucle con Do While y While
// -------------------------------------------------
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Unidad 2: Creación de bucles con Do While y While");
Console.WriteLine("--------------------------------------------------\n");

/*
Vamos a escribir código que seguirá generando números aleatorios entre 1 y 10 hasta que generemos el número 7. Podría tomar solo una iteración para obtener un 7, o podría tomar docenas de iteraciones.
*/

Random random = new();
int current = 0;
int counter = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine($"Número generado: {current}");
    counter++;
} while (current != 7);
Console.WriteLine($"\n-----------------------------------------------------");
Console.WriteLine($"¡Número 7 generado después de {counter} iteraciones!");
Console.WriteLine($"-----------------------------------------------------\n");

// Escibimos una instruccion While que itere siempre que un numero aleatorio sea mayor que algun valor.

int current2 = random.Next(1, 11);
int counter2 = 0;

if (current2 < 3)
    Console.WriteLine($"Número generado: {current2}");

while (current2 >= 3)
{
    Console.WriteLine($"Número generado: {current2}");
    current2 = random.Next(1, 11);
    counter2++;
}
Console.WriteLine($"\n-----------------------------------------------------");
Console.WriteLine($"¡Números generados mayores o iguales que 3: {counter2}!");
Console.WriteLine($"-----------------------------------------------------\n");

// Usando una instruccion continue para ir directamente a la expresión booleana
int current3 = random.Next(1, 11);
int counter3 = 0;

do
{
    counter3++;
    current3 = random.Next(1, 11);
    if (current3 >= 8)
    {
        Console.WriteLine($"Número generado: {current3} // Se salta la iteración.");
        continue;
    }
    Console.WriteLine($"Número generado: {current3}");
} while (current3 != 7);

Console.WriteLine($"\n-----------------------------------------------------");
Console.WriteLine($"¡Número 7 generado después de {counter3} iteraciones!");
Console.WriteLine($"-----------------------------------------------------\n");

// -------------------------------------------------
// Fin del programa
// -------------------------------------------------
Console.WriteLine("\n\nPulse alguna tecla para continuar...");
Console.ReadKey();
