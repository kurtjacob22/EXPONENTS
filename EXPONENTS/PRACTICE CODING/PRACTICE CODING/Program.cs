using System;
using System.Linq;


namespace PRACTICE_CODING
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] letters = new string[] {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n"
                ,"o","p","q","r","s","t","u","v","w","x","y","z"
            };

            Console.WriteLine("EXPONENTS\n");

            Console.Write("Enter your base: ");
            string bas = Console.ReadLine().ToLower();

            while (bas == "" || letters.Contains(bas)) {
                Console.Write("Enter your base: ");
                bas = Console.ReadLine().ToLower();

                if (!letters.Contains(bas)) {
                    break;
                }
            }

            Console.Write("Enter your exponent: ");
            string exponent = Console.ReadLine();

            while (exponent == "" || letters.Contains(exponent))
            {
                Console.Write("Enter your base: ");
                exponent = Console.ReadLine().ToLower();

                if (!letters.Contains(exponent))
                {
                    break;
                }
            }


            int baseConverted = Convert.ToInt32(bas);
            int exponentConverted = Convert.ToInt32(exponent);

            Console.WriteLine(Exponent(baseConverted, exponentConverted));

            Console.ReadKey();
        }

        public static int Exponent(int bas, int exp) {
            int result = 1;
            int x;
            for (x = 1; x <= exp; x++) { 
                result = result * bas;
            }
            return result;

        }

        
    }
}
