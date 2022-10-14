internal class Program
{
    static void Main(string[] args)
    {
            string contraseña;
            string usuario;
            int c = 0;

        Boolean kld;
        do
        {
            Console.WriteLine("Ingrese sus credenciales");
            Console.WriteLine("Ingrese usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            contraseña = Console.ReadLine();

            kld = Login(usuario, contraseña);
            if (kld == true)
            {
                Console.WriteLine("Usuario y contraseña correcto");
                c = 3;
            }
            else
            {
                c++;
                Console.WriteLine("Usuario y contrasela incorrecta, intente de nuevo");
                Console.WriteLine("Numero de intento realizados" + c);
            }
        } while (c < 3);
        Console.ReadKey();
    }
    static bool Login(string usua, string contra)
    {

        if (usua == "usuario1" && contra == "asdasd")
        {
            return true;
        }
        else
        {

            return false;
        }


    }

}