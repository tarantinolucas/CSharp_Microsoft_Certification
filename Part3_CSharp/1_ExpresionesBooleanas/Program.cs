Console.Clear();

Console.WriteLine("-----------------------------");
Console.WriteLine("Parte 3: Introducción a C#");
Console.WriteLine("-----------------------------");
Console.WriteLine("1_Expresiones Booleanas");
Console.WriteLine("-----------------------------\n");

// --------------------------------
// Modulo 2_Expresiones Booleanas
// --------------------------------

// Probando algunas expresiones
Console.WriteLine("Se compara: a == a");
Console.WriteLine("a" == "a"); // True

Console.WriteLine("\nSe compara: a == A");
Console.WriteLine("a" == "A"); // False

Console.WriteLine("\nSe compara: 1 == 2");
Console.WriteLine(1 == 2); // False

Console.WriteLine("\nSe declara myValue = a y se lo compara con a");
string myValue = "a";
Console.WriteLine(myValue == "a"); // True

Console.WriteLine($"\nSe compara \"a\" con \"a \" (con espacio al final)");
Console.WriteLine("a" == "a "); // False

Console.WriteLine(
    "\nSe declaran value1 = \"a \" y value2 = \"A \" (con espacio al final), se les aplica el metodo Trim() y ToLower() y se comparan"
);
string value1 = "a ";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // True

// Fin del programa
Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
