using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            else if (num == 2)
                return true;

            else if (num % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public static List<double> Generate(int size)
        {
            List<double> prime = new List<double>();

            for (int i = 2; i <= size; i++)
            {
                if (IsPrime(i))
                {
                    prime.Add(i);
                }
            }

            return prime;
        }
    }
}
