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

// Desafío de código: escribir código para implementar reglas de juego.

/*
Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
El héroe y el monstruo comenzarán con 10 puntos de salud.
Todos los ataques tendrán un valor comprendido entre 1 y 10.
El héroe ataca primero.
Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
Imprima el ganador.
*/

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Unidad 4: Desafío de código, Juego de batalla");
Console.WriteLine("--------------------------------------------------\n");

int heroHealth = 10;
int monsterHealth = 10;
int attackRandomValue;
;
int minAttack = 1;
int maxAttack = 10;

// bool isHeroTurn = true; // Nos ahorarriamos esta declaración y se ejecutaria el codigo la mitad de veces si usamos un bucle do-while

Random attackRandom = new();

do
{
    // Solución del desafío mas eficiente planteada en el curso
    attackRandomValue = attackRandom.Next(minAttack, maxAttack);
    monsterHealth -= attackRandomValue;
    Console.WriteLine(
        $"El héroe ataca. \tDaño: {attackRandomValue} pts. \tVida del monstruo: {monsterHealth} hp."
    );

    if (monsterHealth <= 0)
        continue;

    attackRandomValue = attackRandom.Next(minAttack, maxAttack);
    heroHealth -= attackRandomValue;
    Console.WriteLine(
        $"El monstruo ataca. \tDaño: {attackRandomValue} pts. \tVida del héroe: {heroHealth} hp."
    );
    /*
    Esta es la solución que cree yo

    if (isHeroTurn && heroHealth > 0 && monsterHealth > 0)
    {
        attackRandomValue = attackRandom.Next(minAttack, maxAttack);
        monsterHealth -= attackRandomValue;
        Console.WriteLine(
            $"El héroe ataca. \tDaño: {attackRandomValue} pts. \tVida del monstruo: {monsterHealth} hp."
        );
        isHeroTurn = false;
    }
    else
    {
        attackRandomValue = attackRandom.Next(minAttack, maxAttack);
        heroHealth -= attackRandomValue;
        Console.WriteLine(
            $"El monstruo ataca. \tDaño: {attackRandomValue} pts. \tVida del héroe: {heroHealth} hp."
        );
        isHeroTurn = true;
    }
    */
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth <= 0)
{
    Console.WriteLine("\n--------------------------------------------------");
    Console.WriteLine("El monstruo ha ganado!");
    Console.WriteLine("--------------------------------------------------");
}
else
{
    Console.WriteLine("\n--------------------------------------------------");
    Console.WriteLine("El héroe ha ganado!");
    Console.WriteLine("--------------------------------------------------");
}

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Unidad 5: Proyecto de código 1, validar entrada de enteros");
Console.WriteLine("----------------------------------------------------------\n");

// string? readResult; // string? permite que la variable sea nula.
// readResult = Console.ReadLine(); // Lee la entrada del usuario y la guarda en readResult, permitiendo que sea nula si el usuario no ingresa nada.

// int.TryParse(readResult, out int result); // Intenta convertir la entrada del usuario a un entero. Si tiene éxito, 'result' contendrá el valor convertido; de lo contrario, 'result' será 0 y se puede manejar el error.

/*
Estas son las condiciones que el primer proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

Dentro del bloque de iteración:
* La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
* La solución debe asegurarse de que la entrada es una representación válida de un entero.
* Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.
* La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
* Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
*/

Console.WriteLine("Por favor, ingrese un número entero entre 5 y 10:");
int userInput;

do
{
    // string? readResult = Console.ReadLine(); // Se comenta esta linea para continuar con el resto del curso. // Descomentar esta linea y eliminar la siguiente para permitir la entrada del usuario.
    string readResult = "6"; // <--- Comentar esta linea para permitir la entrada del usuario.
    if (int.TryParse(readResult, out userInput))
    {
        if (userInput < 5 || userInput > 10)
        {
            Console.WriteLine("Por favor, ingrese un número entero entre 5 y 10:");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero entre 5 y 10:");
    }
} while (userInput < 5 || userInput > 10);

Console.WriteLine("\n--------------------------------------------------");
Console.WriteLine($"¡Número {userInput} aceptado!");
Console.WriteLine("--------------------------------------------------");

/*
Resolución alternativa del desafío de código:

string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/

Console.WriteLine("\n----------------------------------------------------------");
Console.WriteLine("Unidad 5: Proyecto de código 2, Validar entrada de cadena");
Console.WriteLine("----------------------------------------------------------\n");

/*
Estas son las condiciones que el segundo proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y finales.
La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
*/

Console.WriteLine(
    "Por favor, ingrese uno de los siguientes roles: Administrador, Director o Usuario:\n"
);

string userRole = "";

// string? readRole = ""; // Se harcodea entrada para continuar con el curso. // Descomentar esta linea y eliminar la siguiente para permitir la entrada del usuario.
string? readRole = "administrador"; // <--- Comentar esta linea para permitir la entrada del usuario.

while (readRole != "administrador" && readRole != "director" && readRole != "usuario")
{
    readRole = Console.ReadLine()?.Trim().ToLower();

    if (readRole == "administrador" || readRole == "director" || readRole == "usuario")
    {
        userRole = readRole;
        break;
    }
    else
    {
        Console.WriteLine(
            "Entrada no válida. Por favor, ingrese uno de los siguientes roles: Administrador, Director o Usuario:\n"
        );
    }
}

Console.WriteLine($"\n--------------------------------------------------");
Console.WriteLine($"¡Rol {userRole} aceptado!");
Console.WriteLine("--------------------------------------------------\n");

/* Resolución alternativa del desafío de código:

string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/

// ----------- Separador de Secciones -----------

Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("Unidad 5: Proyecto de código 3, Procesar el contenido de una matriz de cadenas");
Console.WriteLine("----------------------------------------------------------------------------\n");

/*
Estas son las condiciones que el tercer proyecto de codificación debe implementar:

La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

La solución debe declarar una variable de enteros denominada periodLocation que se pueda usar para contener la ubicación del carácter de punto dentro de una cadena.

La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz. La variable de cadena que procesará dentro de los bucles debe denominarse myString.

En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer carácter de punto de la variable myString. La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún carácter de punto en la cadena, se devolverá un valor de -1.

La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las cadenas que se procesan.

En el bucle interno, la solución no debe mostrar el carácter de punto.

En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información de cadena.
*/

// Conociendo métodos de la clase String:

/*
string exampleString = "I like pizza. I like roast chicken. I like salad";
string auxString;
string auxString2;

int periodLocation = exampleString.IndexOf(".");
auxString = exampleString.Remove(0, periodLocation + 1).TrimStart();
auxString2 = exampleString.Substring(0, periodLocation).TrimStart();
int periodLocation1;

Console.WriteLine("// Pruebas preliminares:\n");
Console.WriteLine($"Ubicación del primer punto: {periodLocation}\n");
Console.WriteLine($"Cadena restante despues de eliminar hasta el primer punto: {auxString}\n");
Console.WriteLine($"Cadena antes del primer punto luego de eliminar la primera: {auxString2}\n");
Console.WriteLine($"Cadena original al finalizar las operaciones: {exampleString}\n");

do
{
    periodLocation1 = exampleString.IndexOf(".");

    if (periodLocation1 != -1)
    {
        Console.WriteLine(exampleString.Substring(0, periodLocation1).TrimStart());
        exampleString = exampleString.Remove(0, periodLocation1 + 1).TrimStart();
        periodLocation = exampleString.IndexOf(".");
    }
    else
    {
        Console.WriteLine(exampleString);
    }
} while (periodLocation1 != -1);

*/
string[] myStrings = new string[2]
{
    "I like pizza. I like roast chicken. I like salad",
    "I like all three of the menu choices",
};

int periodLocation;

foreach (string myString in myStrings)
{
    string copyString = myString;

    while (copyString.Length > 0)
    {
        periodLocation = copyString.IndexOf(".");

        if (periodLocation != -1)
        {
            Console.WriteLine(copyString.Substring(0, periodLocation).TrimStart());
            copyString = copyString.Remove(0, periodLocation + 1).TrimStart();
        }
        else
        {
            Console.WriteLine(copyString);
            copyString = "";
        }
    }
}

/* Resolución alternativa del desafío de código:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/

// -------------------------------------------------
// Fin del programa
// -------------------------------------------------
Console.WriteLine("\n\nPulse alguna tecla para continuar...");
Console.ReadKey();
