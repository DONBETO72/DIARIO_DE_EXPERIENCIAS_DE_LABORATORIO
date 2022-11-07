static void Main ()
{
    //definicion 

    int[,] matriciña = new int[40, 50];
    int positivos = 0;
    int negativos = 0;


    // llenado
    Random r = new Random();
    for (int f = 0; f < 40; f++)
    {
        for (int c = 0; c < 50; c++)
        {
            matriciña[f, c] = r.Next(-300, 350);

        }
    }


    // SUMA 

    for (int f = 0; f < 40; f++)
    {
        for (int c = 0; c < 50; c++)
        {
            if (matriciña[f, c] >= 0)
            {
                positivos = positivos + matriciña[f, c];
            }
            
            else
            {
                negativos = negativos + matriciña[f, c];
            }

        }

    }

    Console.WriteLine("La suma de los números positivos es " + positivos + ".");
    Console.WriteLine("La suma de los números negativos es " + negativos + ".");
}

Main();