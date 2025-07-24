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
// -------------------------------------------------------
Console.WriteLine("\n----------------------------------");
Console.WriteLine("Unidad 3: Operadores condicionales");
Console.WriteLine("------------------------------------");

// Formato basico de un operador condicional:
// condición ? valorSiVerdadero : valorSiFalso
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmout = 1001;

// int discount = saleAmout > 1000 ? 100 : 50; // Comentamos esta linea porque vamos a utilizar un operador condicional insertado.
Console.WriteLine(
    $"El objetivo es que se aplique un descuento de 100 si la venta es mayor a 1000, de lo contrario será de 50."
);
Console.WriteLine(
    $"En este caso, la venta es de {saleAmout}, por lo tanto el descuento aplicado es: {(saleAmout > 1000 ? 100 : 50)}"
);

// -------------------------------------------------------
// Unidad 4 y 5: Desafío de operadores condicionales
// -------------------------------------------------------
Console.WriteLine("\n-------------------------------------------");
Console.WriteLine("Unidad 4: Desafío de operadores condicionales");
Console.WriteLine("---------------------------------------------");

/* Desafío:
En este desafío, implementará un operador condicional para simular un "volteo de moneda". La lógica de decisión resultante mostrará heads o tails.
*/

Random random = new Random();
int coinFlip = random.Next(0, 2);

Console.WriteLine(
    $"Se ha lanzado una moneda y el resultado es: {(coinFlip == 0 ? "heads" : "tails")}"
);

// -------------------------------------------------------
// Unidad 6: Desafío con expresiones booleanas
// -------------------------------------------------------
Console.WriteLine("\n-------------------------------------------");
Console.WriteLine("Unidad 6: Desafío con expresiones booleanas");
Console.WriteLine("---------------------------------------------");

/* Desafío:
En este desafío, implementará la lógica de decisión basada en una serie de reglas de negocio. Las reglas de negocio especifican el acceso que se concede a los usuarios en función de sus permisos basados en roles y su nivel de carrera. Las ramas de código muestran un mensaje diferente al usuario en función de sus permisos y nivel.
*/

string permission = "Admin"; // Modifique estos valores para probar diferentes escenarios
int level = 56; // Modifique estos valores para probar diferentes escenarios

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level > 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

/* Posible solucion alternativa:

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

*/

// Fin del programa
Console.WriteLine("\n------------------------------------");
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
