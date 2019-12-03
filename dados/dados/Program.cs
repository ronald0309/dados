using System;

namespace dados
{
    class Program
    {
        // variables para realizar las sumatorias
        static int sumSup = 0;
        static int sumInf = 0;
        static int sumFront = 0;
        static int sumAtras = 0;
        static int sumLatIz = 0;
        static int sumLatDe = 0;
        /// <summary>
        ///  Funcion principal para imprimir el dado 
        /// </summary>
        /// <param name="superior">Valor parte superior</param>
        /// <param name="caraFrontal">valor de la parte frontal</param>
        /// <param name="laterales">valor del lateral derecho</param>
        static void imprimirDado(int superior, int caraFrontal, int laterales)
        {
            imprimirSuperior(superior);
            imprimirCaraFrontal(caraFrontal, laterales);
            imprimirInferior(7 - superior);
        }
        ///Imprime la cara superior del dado 
        static void imprimirSuperior(int superior)
        {
            Console.WriteLine("             ########");
            Console.WriteLine("             #      #");
            Console.WriteLine("             #   {0}  #", superior);
            Console.WriteLine("             #      #");

        }
        /// <summary>
        /// Imprime las caras, laterales, fontal y tracera, del dado 
        /// </summary>
        /// <param name="caraFrontal">Valor de la parte frontal del dado</param>
        /// <param name="laterales">Valor del lateral derecho</param>
        static void imprimirCaraFrontal(int caraFrontal, int laterales)
        {

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
            imprimirDado(superior, frontal, lateral);
            sumatoria(superior, 7 - superior, lateral, 7 - lateral, frontal, 7 - frontal);
        }
        /// <summary>
        /// Se suman las caras de los dados
        /// </summary>
        /// <param name="superior">Valor de la cara superior del dado</param>
        /// <param name="inferior">Valor de la cara inferior del dado</param>
        /// <param name="lateralD">Valor de la cara lateral derecha del dado</param>
        /// <param name="lateralI">Valor de la cara lateral izquierda del dado</param>
        /// <param name="frontal">Valor de la cara frontal del dado</param>
        /// <param name="atras">Valor de la cara tracera del dado</param>
        static void sumatoria(int superior, int inferior, int lateralD, int lateralI, int frontal, int atras)
        {
            sumSup += superior;
            sumInf += inferior;
            sumLatDe += lateralD;
            sumLatIz += lateralI;
            sumFront += frontal;
            sumAtras += atras;

        }
        /// <summary>
        /// Se imprime la suma de cada cara del dado.
        /// </summary>
        static void imprimirSuma()
        {
            Console.WriteLine("Suma de la parte superior {0}", sumSup);
            Console.WriteLine("Suma de la parte inferior {0}", sumInf);
            Console.WriteLine("Suma de la parte lateral derecha {0}", sumLatDe);
            Console.WriteLine("Suma de la parte lateral izquierda {0}", sumLatIz);
            Console.WriteLine("Suma de la parte frontal {0}", sumFront);
            Console.WriteLine("Suma de la parte tracera {0}", sumAtras);
        }
        /// <summary>
        /// Se limpia las variables de la suma de las caras.
        /// </summary>
        static void limpiarValores()
        {
            sumSup = 0;
            sumInf = 0;
            sumFront = 0;
            sumAtras = 0;
            sumLatIz = 0;
            sumLatDe = 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Precione enter para girar los dados.");
            int frontal;
            Random random = new Random();
            // Se valida si se preciona un tecla diferente a la tecla escape 
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                //Se valida que la tecla precionada sea enter 
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    //Se le asigna el valor de la cara frontal 
                    frontal = random.Next(1, 7);
                    Console.WriteLine("Nueva Visualizacion");
                    // se llama a la funcion para generar los otros valores ramdom e imprimir el primer dado  
                    randomDado(frontal);
                    //se llama a la funcion para generar los otros valores ramdom e imprimir el segundo dado
                    randomDado(frontal);
                    // se imprime las sumatorias
                    imprimirSuma();
                    // se limpian los valores de la sumatoria
                    limpiarValores();
                }
            }
        }
    }
}
