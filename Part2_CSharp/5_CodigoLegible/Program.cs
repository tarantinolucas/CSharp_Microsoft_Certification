// ---------------------------------------------------------
// Creación de código legible con convenciones, espacios
// en blanco y comentarios en C#
// ---------------------------------------------------------

Console.WriteLine("\n----------------------------------------------");
Console.WriteLine(
    $@"Creación de código legible con convenciones,
espacios en blanco y comentarios en C#"
);
Console.WriteLine("----------------------------------------------\n");

// ----------------------------------------------------------
// Unidad 2: Reglas y convenciones de variables
// ----------------------------------------------------------

// Convenciones para nombre de variables
// Las variables pueden contener caracteres alfanumerico y caracter de subrayado (_)
// No se permiten #, - o el signo $
// No pueden comenzar con un número
// Las varaibles que comienzan con _ suelen reservarse para variables privadas
// Las variables no pueden contener palabras reservadas de C# como float, int, string, etc.
// Los nombre de variables deben ser descriptivas
// Las variables son sensibles a mayúsculas y minúsculas myValue es diferente a MyValue
// Debemos usar camelCase para variables y métodos
// Los nombres de variables deben ser palabras completas anexadas no contracciones
// Los nombres de las variables no deben contener el tipo de dato

// ------------------------------------------------------------
// Unidad 3: Creacion de comentarios de codigo efectivos
// ------------------------------------------------------------

// Comentarios de bloque /* ... */
/*
string firstName = "Bob";
int widgetPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetPurchased} widgets.");
*/

// Testing a change to the message
// int widgetSold = 7;
// Console.WriteLine($"{firstName} sold {widgetSold} widgets.");

/*

Ejemplo de codigo con comentarios de baja calidad

Random random = new();
string[] orderIDs = new string[5];

// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current orderID
    orderIDs[i] = prefix + suffix;
}

// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/

// Ejemplo de código con comentarios de alta calidad
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// ------------------------------------------------------------
// Unidad 4: Espacios en blanco y formato de código
// ------------------------------------------------------------

/*

Ejemplo de código con mala legibilidad

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

*/

// Ejemplo de código con buena legibilidad con el agregado de espacios en blanco entre partes del codigo que realizan distintas tareas
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// ------------------------------------------------------------
// Unidad 5: Actividad de mejora de legibilidad de codigo
// ------------------------------------------------------------

/*
    This code reverses a message, counts the number of times
    a particular character appears, then prints the results
    to the console window.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
