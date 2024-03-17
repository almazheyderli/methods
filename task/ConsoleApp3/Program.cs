namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 34, 56, 78 };
            int[] arrr = { 1, 56, 79 };
            Strings(arr, arrr);
        }
        public static void Strings(int[]arr1, int[] arr2 )
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                    }
                }
            }
            

            
            
        }
            
    }
}
