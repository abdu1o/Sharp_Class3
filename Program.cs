using EvenNumbers;
using OddNumbers;
using PrimeNumbers;
using FibonachiNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> even = EvenNumbers.EvenNumbers.Generate(10);
            Console.WriteLine("Even numbers: " + string.Join(", ", even));

            List<double> odd = OddNumbers.OddNumbers.Generate(10);
            Console.WriteLine("Odd numbers: " + string.Join(", ", odd));

            List<double> prime = PrimeNumbers.PrimeNumbers.Generate(10);
            Console.WriteLine("Prime numbers: " + string.Join(", ", prime));

            List<int> fibonachi = FibonachiNumbers.FibonachiNumbers.Generate(10);
            Console.WriteLine("Fibonachi numbers: " + string.Join(", ", fibonachi));

        }
    }
}
