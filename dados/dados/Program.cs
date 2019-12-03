using System;

namespace dados
{
    class Program
    {
        // funcion principal para imprimir el dado 
        static void imprimirDado(int superior, int caraFrontal, int laterales)
        {
            imprimirSuperior(superior);
            imprimirCaraFrontal(caraFrontal, laterales);
            imprimirInferior(7 - superior);
        }
        //imprime la cara superior del dado 
        static void imprimirSuperior(int superior)
        {
            Console.WriteLine("             ########");
            Console.WriteLine("             #      #");
            Console.WriteLine("             #   {0}  #", superior);
            Console.WriteLine("             #      #");

        }
        //imprime las caras, laterales, fontal y tracera, del dado 
        static void imprimirCaraFrontal(int caraFrontal, int laterales)
        {
            int max = 7;
            Console.WriteLine("############################");
            Console.WriteLine("#     #      #      #      #");
            Console.WriteLine("#  {0}  #  {1}   #  {2}   #   {3}  #", 7 - caraFrontal, 7 - laterales, caraFrontal, laterales);
            Console.WriteLine("#     #      #      #      #");
            Console.WriteLine("#############################");
        }
        // imprime la parte inferior del dado 
        static void imprimirInferior(int inferior)
        {
            Console.WriteLine("             #      #");
            Console.WriteLine("             #  {0}   #", inferior);
            Console.WriteLine("             #      #");
            Console.WriteLine("             ########");
        }
        //funcion para generar los valores aleatorios del dado 
        static void randomDado()
        {
            Random random = new Random();
            int x;
            int x2;
            int x3;
            x = random.Next(1, 7);
            do
            {
                x2 = random.Next(1, 7);
            } while (x == x2 || x == (7 - x2));
            do
            {
                x3 = random.Next(1, 7);
            } while (x == x3 || x2 == x3|| (7-x) == x3|| (7-x2) == x3);
            Console.WriteLine("Valores del random {0},{1},{2}", x, x2, x3);
        }
        static void Main(string[] args)
        {
            // Se valida si se preciona un tecla diferente a la tecla escape 
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                //Se valida que la tecla precionada sea enter 
                while ( Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Nueva Visualizacion");
                    // se valida que el random funcione 
                    randomDado();
                    // Se imprime el dado.

                    imprimirDado(1, 2, 3);
                }
            }
        }
    }
}
