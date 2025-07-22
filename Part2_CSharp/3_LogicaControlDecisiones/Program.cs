// ---------------------------------------------------------
// Adición de lógica de decisión al código mediante
// instrucciones "if", "else" y "else if" en C#.
// ---------------------------------------------------------

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("Adición de lógica de decisión al código");
Console.WriteLine("mediante instrucciones 'if', 'else' y");
Console.WriteLine("'else if'");
Console.WriteLine("-------------------------------------\n");

// -----------------------------------------------------------------
// Unidad 2: Desarrollo de lógica de decisión con instrucciones IF
// ----------------------------------------------------------------

/*
Consigna del ejercicio:

* En este ejercicio, practicará la escritura de instrucciones if mediante la creación de un juego. Primero definirá las reglas del juego y las implementarás en el código.

* Usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Para calcular la puntuación, evaluará los valores obtenidos. Si la puntuación es mayor que un total arbitrario, se mostrará un mensaje de éxito al usuario. Si la puntuación está por debajo del límite, se mostrará un mensaje de fracaso al usuario.

* Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
* Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
* Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego. De lo contrario, pierde.

*/

// Instanciamos la clase Random
Random dice = new();

// Generamos las 3 tiradas aleatorias de datos
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

/* Comentamos la lógica de la unidad 2

// Verificamos si hay un doble
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    Console.WriteLine("You rolled a double! +2 bonus to total!");
    total += 2;
}

// Verificamos si hay un triple
if ((roll1 == roll2) && (roll1 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

// Administramos escenarios de exito o fracaso
if (total >= 15)
{
    Console.WriteLine("You win!");
}
if (total < 15)
{
    Console.WriteLine("Sorry, you lose!");
}

*/

// -----------------------------------------------------------------
// Unidad 3: Lógica anidada con if, else y else if
// -----------------------------------------------------------------

// Anteriormente vimos como usar instruciones IF para implementar las reglas del juego. Ahora vamos a usar if, else y else if para mejorar la lógica del juego y corregir un error de logica.

// En el codigo anterior, si el jugador obtiene un doble y un triple, se le suman ambos puntos extra. Sin embargo, si el jugador obtiene un triple, ya ha obtenido un doble implícitamente. Por lo tanto, si el jugador obtiene un triple, no debería recibir los puntos extra por el doble.

/* Comentamos logica de prueba

// Hardcodeo para probar logica de dobles y triples
roll1 = 6;
roll2 = 6;
roll3 = 6; // Modificar esta linea para triples

*/

/*

Para que el juego sea más divertido, podemos cambiar la dinámica de ganar o perder para adjudicar premios ficticios a cada puntuación. Podemos ofrecer cuatro premios. El jugador solo debe ganar uno:

* Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
* Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
* Si el jugador obtiene una puntuación de 7, gana un viaje.
* De lo contrario, el jugador gana un gatito.

*/

// Sumamos los valores obtenidos de las tiradas
int total = roll1 + roll2 + roll3;

// Mostramos los valores obtenidos de las tiradas
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Verificamos si hay un doble o un triple utilizando logica de decision anidada
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll1 == roll3))
    {
        // Si hay un triple, mostramos el mensaje y sumamos los puntos extra
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        // Si hay un doble, mostramos el mensaje y sumamos los puntos extra
        Console.WriteLine("You rolled a double! +2 bonus to total!");
        total += 2;
    }

    // Nueva mejorra para mostrar el total de puntos si tiene un doble o un triple
    Console.WriteLine($"Total with bonus: {total}");
}

// Mejoramos la logica para mostrar si el usuario gano o no
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

// -----------------------------------------------------------------
// Unidad 4: Actividad para aplicar reglas de negocio
// -----------------------------------------------------------------

/*

Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.

*/

Console.WriteLine("\n-------------------------------------");
Console.WriteLine("Actividad para aplicar reglas de negocio");
Console.WriteLine("-------------------------------------\n");

Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

/*

Reglas del negocio:

* Suscripcion expira en 10 días o menos: Se muestra mensaje 'Your subscription will expire soon. Renew now!'
* Suscripcion expiran en 5 días o menos: Se muestra mensaje 'Your subscription expires in _ days. \nRenew now and save 10%!' Reemplazar _ por el número de días restantes.
* Suscripcion expira en 1 dia: Se muestra mensaje 'Your subscription expires withing a day! \nRenew now and save 20%!'
* Si la susscripcion ha expirado mostrar mensaje: 'Your subscription has expired.'

*/

// Hardcodeamos el valor de daysUntilExpiration para probar la logica
// daysUntilExpiration = 0; // Modificar este valor para probar diferentes escenarios

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine(
        $"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!"
    );
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine(
        $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!"
    );
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon.\nRenew now!");
}
else
{
    Console.WriteLine("Your subscription is still active.");
}
