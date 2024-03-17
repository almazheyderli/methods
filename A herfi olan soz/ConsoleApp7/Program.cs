namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Arif", "Yusif", "Anar", };
            BasHerf(myArray);
        }
        public static void BasHerf(string[] c)
        {

            for (int i = 0; i < c.Length; i++)
            {
                string soz = c[i];
                if (soz[0] == 'A' && soz[i] != ' ')
                {
                    Console.WriteLine(soz);

                }
            }
        }
    }



    }

