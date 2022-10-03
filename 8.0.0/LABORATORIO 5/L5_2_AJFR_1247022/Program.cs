//EJERCICIO 02//
using System.Diagnostics.Tracing;

Console.WriteLine("Ejercicio 02");
Console.WriteLine("Ingresar el número del día");

int numerodedia = 0;
numerodedia = Convert.ToInt32(Console.ReadLine());

if (numerodedia == 1)
{
    Console.WriteLine("Lunes");
}
if (numerodedia == 2)
{
    Console.WriteLine("Martes");
}
if (numerodedia == 3)
{
    Console.WriteLine("Miércoles");
}
if (numerodedia == 4)
{
    Console.WriteLine("Jueves");
}
if (numerodedia == 5)
{
    Console.WriteLine("Viernes");
}
if (numerodedia == 6)
{
    Console.WriteLine("Sábado");
}
if (numerodedia == 7)
{
    Console.WriteLine("Domingo");
}

if (numerodedia < 1)
{
    Console.WriteLine("Error. Ingrese un número del 1 al 7 para recibir el día de la semana.");
}

if (numerodedia > 7)
{
    Console.WriteLine("Error. Ingrese un número del 1 al 7 para recibir el día de la semana.");
}