using System.Reflection.Metadata;

Console.Clear();

Console.WriteLine("-----------------------------------------");
Console.WriteLine("Parte 4: Introducción a C#");
Console.WriteLine("-----------------------------------------");
Console.WriteLine("1_Elección del Tipo de Dato Correcto");
Console.WriteLine("-----------------------------------------\n");

// Unidad 3: Deteccion de tipos de enteros

Console.WriteLine("Signed integral types (enteros con signo):");
Console.WriteLine("sbyte: " + sbyte.MinValue + " a " + sbyte.MaxValue);
Console.WriteLine("short: " + short.MinValue + " a " + short.MaxValue);
Console.WriteLine("int: " + int.MinValue + " a " + int.MaxValue);
Console.WriteLine("long: " + long.MinValue + " a " + long.MaxValue);

Console.WriteLine("\nUnsigned integral types (enteros sin signo):");
Console.WriteLine("byte: " + byte.MinValue + " a " + byte.MaxValue);
Console.WriteLine("ushort: " + ushort.MinValue + " a " + ushort.MaxValue);
Console.WriteLine("uint: " + uint.MinValue + " a " + uint.MaxValue);
Console.WriteLine("ulong: " + ulong.MinValue + " a " + ulong.MaxValue);

// Unidad 4: Detección de tipos de punto flotante

// -------------------------------------------------
// Fin del programa
// -------------------------------------------------
Console.WriteLine("\n\nPulse alguna tecla para continuar...");
Console.ReadKey();
