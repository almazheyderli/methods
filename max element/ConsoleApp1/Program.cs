namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringMax(23, 4, 5, 6, 7));
        }
        public static int StringMax(params int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
