// See https://aka.ms/new-console-template for more information
using System;

namespace Mezenne_hesablama_Programi
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 10000;
            double USD = 0.5882f * amount;
            double EUR = 0.5494f * amount;
            double RUB = 37.7358f * amount;

            Console.WriteLine("Mebleg (AZN) :");
            Console.WriteLine(amount);
            Console.WriteLine("");
            Console.WriteLine("ABŞ dolları (USD) :");
            Console.WriteLine(USD);
            Console.WriteLine("");
            Console.WriteLine("Avro (EUR) :");
            Console.WriteLine(EUR);
            Console.WriteLine("");
            Console.WriteLine("Rusiya rublu(RUB) :");
            Console.WriteLine(RUB);
        }
    }
}