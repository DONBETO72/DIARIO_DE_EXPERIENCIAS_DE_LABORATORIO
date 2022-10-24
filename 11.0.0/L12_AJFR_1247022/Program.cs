class Program
{
    static void Main()
    {

        
        int[] notas = new int[15];


            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }

        double prom = 0;
        double suma = 0;
            for (int i = 0; i < 15; i++)
            {
                suma = suma + notas[i];
            }

        prom = suma / 15;
        Console.WriteLine("El promedio obtenido por las notas es de: " + prom);

       
    }
}