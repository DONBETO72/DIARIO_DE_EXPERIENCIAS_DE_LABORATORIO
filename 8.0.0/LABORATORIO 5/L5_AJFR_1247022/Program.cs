
    
        /*EJERCICIO 01*/
        int numeroEntero=0;

        //Mensaje en pantalla//
        Console.WriteLine("EJERCICIO 01");
        Console.WriteLine("Numero entero");

    //siguiente instruccion recibe y almacena el número//
        numeroEntero = Convert.ToInt32(Console.ReadLine());
    if (numeroEntero >= 1)
{
    Console.WriteLine("El número es positivo");
}
    else if (numeroEntero <= -1)
    {
    Console.WriteLine("El número es negativo");
    }
    else if (numeroEntero==0)
{
    Console.WriteLine("El número es 0");
}