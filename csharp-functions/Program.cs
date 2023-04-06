using System.Buffers;
using System.Linq;
using System.Threading.Channels;

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

            Console.WriteLine("Il quadrato della somma dell' array: ");
            Console.WriteLine(Quadrato(Somma(myArrSum)));

            Console.WriteLine("********* BONUS **********");
            //BONUS
            Console.Write("Inserisci la grandezza del tuo array: ");
            int dimensioni = Int32.Parse(Console.ReadLine());
            int[] myArrBello = ArrayPersonalizzato(dimensioni);
            Console.WriteLine("Il tuo array:");
            StampaArray(myArrBello);
            StampaArray(ElevaArrayAlQuadrato(myArrBello));

            Console.WriteLine("La tua somma: ");
            Console.WriteLine(Somma(myArrBello));

            Console.WriteLine("Il quadrato della somma del tuo array: ");
            Console.WriteLine(Quadrato(Somma(myArrBello)));



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

        //BONUS
        public static int[] ArrayPersonalizzato(int dimensioni)
        {
            int[] array = new int[dimensioni];
            for (int i = 0; i < dimensioni; i++)
            {
                Console.Write("Inserisci i numeri");
                int numeriIns = Int32.Parse(Console.ReadLine());
                array[i] = numeriIns;
            }
            return array;
        }
    }
}