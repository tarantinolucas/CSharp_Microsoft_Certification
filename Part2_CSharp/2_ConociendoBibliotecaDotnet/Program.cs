// ------------------------------------------------------------------
// Unidad 3: Llamada de métodos de una clase de la Biblioteca de .NET
// ------------------------------------------------------------------

// Con el comando 'dotnet new console' se crea un nuevo proyecto de consola C#

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("Invocando diferentes tipos de métodos");
Console.WriteLine("en la Biblioteca de .NET");
Console.WriteLine("-------------------------------------\n");

// Simulación del lanzamiento de un dado mediante el metodo Next() de la clase Random
// Random dice = new Random();
// La nueva sintaxis de C# permite crear instancias de clases de forma más concisa
Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine($"Se ha lanzado un dado y ha salido: {roll}\n");

// En C# existen dos tipos de métodos:
// 1. Métodos de instancia: pertenecen a una instancia de una clase. Tambien conocidos como metodos con estado.
// 2. Métodos estáticos: pertenecen a la clase en sí y no requieren una instancia para ser invocados. Tambien conocidos como metodos sin estado.

// Como vimos arriba, la clase Random es un ejemplo de un método de instancia. Console.WriteLine() es un ejemplo de un método estático, ya que pertenece a la clase Console y no requiere una instancia para ser invocado.

// El ejemplo de abajo generaria un error de compilación, ya que no se puede invocar un método con estado sin una instancia de la clase.
// int result = Random.Next();
// Console.WriteLine($"El resultado del método con estado Next() de la clase Random es: {result}\n");

// ------------------------------------------------------------------
// Unidad 4: Devolución de valores y parametros de métodos
// ------------------------------------------------------------------

// void -> Metodo nulo o que no devuelve un valor
// Cuando se llama a un método se le pueden pasar valores, llamados argumentos, que son utilizados por el método para realizar su tarea. Estos argumentos se definen en la declaración del método como parámetros.

// Parámetros -> Hace referencia a la variable que se usa dentro del método.
// Argumentos -> Hace referencia a los valores que se pasan a un método cuando se lo llama.

// Los argumentos pueden ser de diferentes tipos, como enteros, cadenas de texto, objetos, etc. El tipo de dato del argumento debe coincidir con el tipo de dato del parámetro definido en el método.

// A continuación veremos ejemplos de métodos sobrecargados, que son métodos que tienen el mismo nombre pero diferentes parámetros. Esto permite que un método pueda realizar diferentes tareas según los argumentos que se le pasen.

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Se ha lanzado un dado y ha salido: {roll1}");
Console.WriteLine($"Se ha lanzado un dado y ha salido: {roll2}");
Console.WriteLine($"Se ha lanzado un dado y ha salido: {roll3}");

// ------------------------------------------------------------------
// Unidad 5: Detectar e implementar llamada de métodos
// ------------------------------------------------------------------

// Desafío de código: llamaremos a un metodo de la clase Math para que devuelva el mayor de dos números.
int firstValue = 500;
int secondValue = 600;
int largestValue = Math.Max(firstValue, secondValue);

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("Llamada al método Max() de la clase Math");
Console.WriteLine($"\nEl primer número es: {firstValue}");
Console.WriteLine($"El segundo número es: {secondValue}");
Console.WriteLine($"\nEl mayor de los dos números es: {largestValue}\n");
