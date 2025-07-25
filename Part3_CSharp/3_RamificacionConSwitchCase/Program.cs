using System.Reflection.Metadata;

Console.Clear();

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Parte 3: Introducción a C#");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("3_Ramificación con Switch Case");
Console.WriteLine("-----------------------------------------\n");

// -------------------------------------------------
// Unidad 2_Implementacion de una instruccion switch
// -------------------------------------------------
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Unidad 2: Implementacion de una instruccion switch");
Console.WriteLine("--------------------------------------------------\n");

// Probando una instrucción switch
int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

// -------------------------------------------------
// Fin del programa
// -------------------------------------------------
Console.WriteLine("\n\nPulse alguna tecla para continuar...");
Console.ReadKey();
