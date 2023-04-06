namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            StampaArray(myArr);
        }

        public static void StampaArray(int[] array)
        {   
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Elemento {i}");
            }
        }
    }
}