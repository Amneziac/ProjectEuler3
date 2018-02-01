using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 x = 600851475143;

            //get ALL factors of number
            List<Int64> factors = getFactors(x);

            List<Int64> primeFactors = new List<Int64>();

            foreach (Int64 f in factors)
            {
                //if its prime add it to list of prime factors
                if (getFactors(f).Count == 2)
                {
                    primeFactors.Add(f);
                }
            }

            Int64 largestPrime = primeFactors.Last();

            Console.WriteLine(largestPrime);
        }

        static List<Int64> getFactors(Int64 x)
        {
            List<Int64> factors = new List<Int64>();

            for (Int64 i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    factors.Add(i);
                    x = x / i;
                }
            }

            return factors;
        }
    }
}
