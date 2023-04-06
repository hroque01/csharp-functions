using System.Buffers;
using System.Linq;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* PRIMO ESERCIZIO **********");
            //Primo esercizio
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            StampaArray(myArr);

            Console.WriteLine("********* SECONDO ESERCIZIO **********");
            //Secondo esercizio
            Quadrato(5);
            Console.WriteLine(Quadrato(5));

            Console.WriteLine("********* TERZO ESERCIZIO **********");
            //Terzo esercizio
            StampaArray(ElevaArrayAlQuadrato(myArr));

            Console.WriteLine("********* QUARTO ESERCIZIO **********");
            //Quarto esercizio
            int[] myArrSum = { 2, 6, 7, 5, 3, 9 };

            Console.WriteLine("Stampare l'array fornito: ");
            StampaArray(myArrSum);

            Console.WriteLine("Stampare l'array fornito elevato al quadrato: ");
            StampaArray(ElevaArrayAlQuadrato(myArrSum));

            Console.WriteLine("Stampare la somma dell'array: ");
            Console.WriteLine(Somma(myArrSum));

            Console.WriteLine(Quadrato(Somma(myArrSum)));

        }

        //Primo esercizio
        public static void StampaArray(int[] array)
        {   
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Elemento {array[i]}");
            }
        }

        //Secondo esercizio
        public static int Quadrato(int numero)
        {
            int potenza = numero * numero;
            return potenza;
        }

        //Terzo esercizio
        public static int[] ElevaArrayAlQuadrato(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
            return array;
        }

        //Quarto Esercizio
        public static int Somma(int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            return sum;
        }
    }
}