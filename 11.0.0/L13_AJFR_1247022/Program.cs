class program
{
    static void Main()
    {
        string[] nombre = new string[5];
        int[] edad = new int[5];


        // Ingreso de datos
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona:  ");
                nombre[i] = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona ");
                edad[i] = int.Parse(Console.ReadLine());
        }

        // Reporte de datos
        for (int i = 0; i < 5; i++)
        {
            if (edad[i] >= 18)
            {
                Console.WriteLine(nombre[i] + " es mayor de edad y tiene una edad de  " + edad[i] + " años.");
            }
        }
    }
}
