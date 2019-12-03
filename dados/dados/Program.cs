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
      
        static void randomDado(int frontal)
        {
            Random random = new Random();
            int superior;
            int lateral;
            do
            {
                superior = random.Next(1, 7);
            } while (superior == frontal || superior == (7 - frontal));
            do
            {
                lateral = random.Next(1, 7);
            } while (superior == lateral || frontal == lateral || (7 - superior) == lateral || (7 - frontal) == lateral);
            Console.WriteLine("Valores del random {0},{1},{2}", superior, frontal, lateral);
            imprimirDado(superior, frontal, lateral);
        }
        static void Main(string[] args)
        {
            int frontal;
            Random random = new Random();
            // Se valida si se preciona un tecla diferente a la tecla escape 
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                //Se valida que la tecla precionada sea enter 
                while ( Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    //Se le asigna el valor de la cara frontal 
                    frontal = random.Next(1, 7);
                    Console.WriteLine("Nueva Visualizacion");
                    // se llama a la funcion para generar los otros valores ramdom e imprimir el primer dado  
                    randomDado(frontal);
                    //se llama a la funcion para generar los otros valores ramdom e imprimir el segundo dado
                    randomDado(frontal);
                   
                }
            }
        }
    }
}
