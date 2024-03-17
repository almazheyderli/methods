using System.Diagnostics;
using System.Net.Http.Headers;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product(1, 2, 3, 4 );
        }
        public static void Product( params int[] arr)
        {
            double product = 1;
            for(int i = 0; i < arr.Length; i++)
            {
               product *= arr[i];
              
            }
            Console.WriteLine(product);
        }
    
    
    }
}
