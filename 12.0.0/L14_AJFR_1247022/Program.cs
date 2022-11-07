string opcion;
    
Console.WriteLine("Bienvenido al menú.");
Console.WriteLine("Elija cualquiera de las 3 opciones para proseguir.");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Opción 1");
Console.WriteLine("Para calcular la edad de una persona.");
Console.WriteLine("");
Console.WriteLine("Opción 2");
Console.WriteLine("Para ingresar puesto y su salario.");
Console.WriteLine("");
Console.WriteLine("Opción 3");
Console.WriteLine("Para salir del programa");
Console.WriteLine("");


opcion = Console.ReadLine();


    switch (opcion)
    {
    //caso 1
        case "1":
        string[] nombre = new string[5];
        int[] año = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Ingrese año de nacimiento de la persona");
            año[i] = int. Parse(Console.ReadLine());

        }

        int edadcalculada = 0;
        for ( int i = 0; i<5; i++)
        {
            edadcalculada= 2022 - año[i];
            Console.WriteLine("La edad de " + nombre[i] + " es de " + edadcalculada);
        }

        break;

    // caso 2
        case "2":

        string[] puesto = new string[5];
        int[] salarioEnDeuda = new int[5];


            // DATOS
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el puesto de la persona:  ");
                puesto[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el salario a pagar: ");
                salarioEnDeuda[i] = int.Parse(Console.ReadLine());
            }
            // REPORTE DE DATOS
            for (int i = 0; i < 5; i++)
            {
                    Console.WriteLine("El puesto de "+puesto[i] + " tiene un salario de " + salarioEnDeuda[i] + " quetzales.");
            }

        break;

    // caso 3
        case "3":
        Console.WriteLine("Cerrando programa...");
        Environment.Exit(0);
        break;

            default:
        Console.WriteLine("");
        break;
    }