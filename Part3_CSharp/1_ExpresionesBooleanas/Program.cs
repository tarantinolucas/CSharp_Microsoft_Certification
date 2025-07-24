Console.Clear();

Console.WriteLine("-----------------------------");
Console.WriteLine("Parte 3: Introducción a C#");
Console.WriteLine("-----------------------------");
Console.WriteLine("1_Expresiones Booleanas");
Console.WriteLine("-----------------------------\n");

// ---------------------------------------------
// Unidad 2_Evaluacion de expresiones Booleanas
// ---------------------------------------------

// Probando algunas expresiones
Console.Write("Se compara: a == a: ");
Console.WriteLine("a" == "a"); // True

Console.Write("\nSe compara: a == A: ");
Console.WriteLine("a" == "A"); // False

Console.Write("\nSe compara: 1 == 2: ");
Console.WriteLine(1 == 2); // False

Console.Write("\nSe declara myValue = a y se lo compara con a: ");
string myValue = "a";
Console.WriteLine(myValue == "a"); // True

Console.Write($"\nSe compara \"a\" con \"a \" (con espacio al final): ");
Console.WriteLine("a" == "a "); // False

Console.Write(
    "\nSe declaran value1 = \"a \" y value2 = \"A \" (con espacio al final), se les aplica el metodo Trim() y ToLower() y se comparan: "
);
string value1 = "a ";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // True

// Metodos interesantes de string: Trim() -> elimina espacios en blanco al principio y al final de la cadena y ToLower() -> convierte la cadena a minúsculas.

// Uso del operador de desigualdad (!=)
Console.WriteLine("\nUso del operador de desigualdad (!=): ");
Console.WriteLine("---------------------------------------");

Console.Write("\nSe compara: \"a\" != \"a\": ");
Console.WriteLine("a" != "a"); // False

Console.Write("\nSe compara: \"a\" != \"A\": ");
Console.WriteLine("a" != "A"); // True

Console.Write("\nSe compara: 1 != 2: ");
Console.WriteLine(1 != 2); // True

string myValue2 = "a";
Console.Write($"\nSe declara myValue2 = {myValue2} y se lo compara con != a: ");
Console.WriteLine(myValue2 != "a");

// Uso de operadores de comparación
Console.WriteLine("\nUso de operadores de comparación");
Console.WriteLine("----------------------------------");

Console.Write("\nSe compara: 1 > 2: ");
Console.WriteLine(1 > 2);

Console.Write("\nSe compara: 1 < 2: ");
Console.WriteLine(1 < 2);

Console.Write("\nSe compara: 1 >= 1: ");
Console.WriteLine(1 >= 1);

Console.Write("\nSe compara: 1 <= 1: ");
Console.WriteLine(1 <= 1);

// Métodos que devuelven un valor booleano
Console.WriteLine("\nMétodos que devuelven un valor booleano");
Console.WriteLine("-----------------------------------------");

// Existen muchos metodos asociados a la clase String que devuelven un valor booleano.
string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine($"\nPangrama: {pangram}");
Console.Write("\nSe comprueba si el pangrama contiene la palabra 'fox': ");
Console.WriteLine(pangram.Contains("fox"));

Console.Write("\nSe comprueba si el pangrama contiene la palabra 'cow': ");
Console.WriteLine(pangram.Contains("cow"));

// Negación lógica
Console.Write(
    "\nSe comprueba si el pangrama NO contiene la palabra 'cow' mediante el uso de la negación lógica !: "
);
Console.WriteLine(!pangram.Contains("cow"));

// Operador de desigualdad frente a negación lógica
Console.WriteLine("\nOperador de desigualdad frente a negación lógica");
Console.WriteLine("-------------------------------------------------");

int a = 7;
int b = 6;
Console.Write("\nSe compara: 7 != 6: ");
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.Write("\nSe compara: \"Hello\" != \"Hello\": ");
Console.WriteLine(s1 != s2); // output: False

// -------------------------------------------------------
// Unidad 3: Operadores condicionales
Console.WriteLine("\n----------------------------------");
Console.WriteLine("Unidad 3: Operadores condicionales");
Console.WriteLine("------------------------------------");

// Formato basico de un operador condicional:
// condición ? valorSiVerdadero : valorSiFalso
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmout = 1001;
int discount = saleAmout > 1000 ? 100 : 50; // Si saleAmout es mayor a 1000, discount será 100, de lo contrario será 50
Console.WriteLine($"\nDiscount: {discount}");

// Fin del programa
Console.WriteLine("\n------------------------------------");
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
