using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polindrom(123);
        }
        public static void Polindrom(int a)
        {
            int rev = 0;
            int qaliq = 0;
            int temp= a;
            while (a != 0)
            {
                qaliq = a % 10;
                rev = rev + qaliq;
                a = a - qaliq;
                a = a / 10;
               

            }
            if (rev == temp)
            {
                Console.WriteLine("polindromdur");
            }
            else
            {
                Console.WriteLine("polindrom deyil");
            }

        }
    }
}
