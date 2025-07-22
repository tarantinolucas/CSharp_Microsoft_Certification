// ---------------------------------------------------------
// Almacenamiento e iteración de secuencias de datos
// mediante el uso de matrices y de la instrucción
// “foreach” en C#
// ---------------------------------------------------------

Console.WriteLine("\n----------------------------------------------");
Console.WriteLine(
    $@"Almacenamiento e iteración de secuencias
de datos mediante el uso de matrices y de la
instrucción 'foreach' en C#"
);
Console.WriteLine("----------------------------------------------\n");

// -----------------------------------------------------------------
// Unidad 2: Alamacenamiento e iteracion de secuencias de datos con
// matrices y la instrucción foreach en C#
// ----------------------------------------------------------------

// Declaración de una matriz
// string[] fraudulentOrderIDs = new string[3]; // Declaración de una matriz de 3 elementos

// Asignación de valores a cada uno de los elementos de la matriz

/*
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/

// Podemos asignar los valores directamente al momento de declarar la matriz
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// También hay una forma mas antigua de declarar una matriz que es con llaves
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// fraudulentOrderIDs[3] = "D012"; // Esto causará un error de índice fuera de rango

// Accedemos a los elementos de la matriz de igual manera que se declararon
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Los elementos de la matriz pueden ser redefinidos como cualquier otro tipo de dato
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

// Vemos a continuacion la propiedad Length de la matriz, que permite conocer la cantidad de elementos que tiene
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// -----------------------------------------------------------------
// Unidad 3: Implementación de la instrucción foreach
// ----------------------------------------------------------------

Console.WriteLine($"\n----------------------------------------------");
Console.WriteLine(
    $@"Implementación de la instrucción foreach
----------------------------------------------"
);

// Definimos una matriz de enteros (productos terminados)
int[] inventory = { 200, 450, 700, 175, 250 };

// Definimos una variable que sume el total de productos
int sum = 0;

// Definimos una variable para contar los elementos de la matriz
int bin = 0;

// Creamos la estructura del foreach
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

// Imprimimos el total de productos
Console.WriteLine($"We have {sum} items in inventory.");

// -----------------------------------------------------------------
// Unidad 4: Desafío de pedido fraudulento
// ----------------------------------------------------------------

/*
Desafio:

El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con una frecuencia 25 veces superior a la normal. Deberá escribir otro código que genere el identificador de pedido para los nuevos pedidos que empiecen por la letra "B". El equipo antifraude lo usará para investigar más en profundidad.

*/

Console.WriteLine($"\n----------------------------------------------");
Console.WriteLine(
    $@"Desafío de pedido fraudulento
----------------------------------------------"
);

// Definimos una matriz de pedidos
string[] newOrders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
int fraudulentCount = 0;

foreach (string order in newOrders)
{
    if (order.StartsWith("B"))
    {
        fraudulentCount++;
        Console.WriteLine(
            $@"Fraudulent order detected! {order}. Total of fraudulent orders: {fraudulentCount}"
        );
    }
}

// Imprimimos el total de pedidos y el total de pedidos fraudulentos
Console.WriteLine($"----------------------------------------------");
Console.WriteLine(
    $@"Search completed. 
Total of orders: {newOrders.Length}.
Total of fraudulent orders: {fraudulentCount}."
);
Console.WriteLine("----------------------------------------------\n");
