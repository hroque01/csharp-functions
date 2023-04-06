using System.Buffers;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primo esercizio
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            StampaArray(myArr);

            //Secondo esercizio
            Quadrato(5);
            Console.WriteLine(Quadrato(5));

            //Terzo esercizio
            StampaArray(ElevaArrayAlQuadrato(myArr));
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
    }
}