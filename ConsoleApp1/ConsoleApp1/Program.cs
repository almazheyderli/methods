using System.Reflection.Metadata;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=Convert.ToInt32(Console.ReadLine());
            int result = Fibonacci(n);
            Console.WriteLine(result);
        }
        public static int Fibonacci(int n)
        {
           
            if (n <=1)
            {
                return n;

            }
            int first = 0;
            int second = 1;
            int temp = 0;
         
            for (int i = 2; i <= n; i++)
            {
              

                temp = first + second;
                first = second;
                second = temp;
               
            }

            return temp;

        }
            
    }
}
