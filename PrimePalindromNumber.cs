using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class PrimePalindromNumber
    {
        public static void PrimeNumbers()
        {
            for ( int number = 1; number <= 1000; number++)
            {
                int temp = number;
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(" ");                   
                }

                int num = number;
                int result = 0;
                int rem;

                while (num != 0)
                {
                    rem = num % 10;  
                    result = result * 10 + rem;  
                    num = num / 10;

                }
                if (result == number)
                {
                    Console.Write(result + "is palindrom number");
                }

            }
            
        }
    }
}
