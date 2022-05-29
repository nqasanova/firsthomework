// See https://aka.ms/new-console-template for more information
using System;

namespace Olke_budcesinin_hesablanmasina_aid_proqram
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageBudget = 20000000000f;
            double ministryOfDefense = 0.2f * averageBudget;
            double ministryOfHighTechnologies = 0.1f * averageBudget;
            double leftBudget = 0.7f * averageBudget;

            Console.WriteLine("Budce :");
            Console.WriteLine(averageBudget);
            Console.WriteLine("");
            Console.WriteLine("Mudafie Nazirliyine :");
            Console.WriteLine(ministryOfDefense);
            Console.WriteLine("");
            Console.WriteLine("Yuksek Texnologiyalar Nazirliyine :");
            Console.WriteLine(ministryOfHighTechnologies);
            Console.WriteLine("");
            Console.WriteLine("Yerde qalan budce :");
            Console.WriteLine(leftBudget);
        }
    }
}