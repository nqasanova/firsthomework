// See https://aka.ms/new-console-template for more information
using System;

namespace Kargo_sifarislerinin_hazirlanmasi_ucun_proqram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Firma:";
            string firstBrand = "Adidas";
            string numberOfAdidas = "Ayaqqabı sayı:"; int theNumberOfAdidas = 4;
            string priceOfOneAdidas = "Birinin qiyməti ($):"; int thePriceOfOneAdidas = 200;
            string priceOfAllAdidas = "Hamısının birlikdə qiyməti ($):"; int thePriceOfAllAdidas = theNumberOfAdidas * thePriceOfOneAdidas;

            Console.WriteLine(name);
            Console.WriteLine(firstBrand);
            Console.WriteLine("");
            Console.WriteLine(numberOfAdidas);
            Console.WriteLine(theNumberOfAdidas);
            Console.WriteLine("");
            Console.WriteLine(priceOfOneAdidas);
            Console.WriteLine(thePriceOfOneAdidas);
            Console.WriteLine("");
            Console.WriteLine(priceOfAllAdidas);
            Console.WriteLine(thePriceOfAllAdidas);

            string name2 = "Firma:";
            string secondBrand = "Gucci";
            string numberOfGucci = "Ayaqqabı sayı:"; int theNumberOfGucci = 2;
            string priceOfOneGucci = "Birinin qiyməti ($):"; int thePriceOfGucci = 1000;
            string priceOfAllGucci = "Hamısının birlikdə qiyməti ($):"; int thePriceOfAllGucci = theNumberOfGucci * thePriceOfGucci;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(name2);
            Console.WriteLine(secondBrand);
            Console.WriteLine("");
            Console.WriteLine(numberOfGucci);
            Console.WriteLine(theNumberOfGucci);
            Console.WriteLine("");
            Console.WriteLine(priceOfOneGucci);
            Console.WriteLine(thePriceOfGucci);
            Console.WriteLine("");
            Console.WriteLine(priceOfAllGucci);
            Console.WriteLine(thePriceOfAllGucci);

            string name3 = "Firma:";
            string thirdBrand = "Nike";
            string numberOfNike = "Ayaqqabı sayı:"; int theNumberOfNike = 1;
            string priceOfOneNike = "Birinin qiyməti ($):"; int thePriceOfOneNike = 150;
            string priceOfAllNike = "Hamısının birlikdə qiyməti ($):"; int thePriceOfAllNike = theNumberOfNike * thePriceOfOneNike;
            string finalSpentMoney = "Yekun xərclənən məbləğ :"; int thefinalSpentMoney = thePriceOfAllAdidas + thePriceOfAllGucci + thePriceOfAllNike;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(name3);
            Console.WriteLine(thirdBrand);
            Console.WriteLine("");
            Console.WriteLine(numberOfNike);
            Console.WriteLine(theNumberOfNike);
            Console.WriteLine("");
            Console.WriteLine(priceOfOneNike);
            Console.WriteLine(thePriceOfOneNike);
            Console.WriteLine("");
            Console.WriteLine(priceOfAllNike);
            Console.WriteLine(thePriceOfAllNike);
            Console.WriteLine("");
            Console.WriteLine(finalSpentMoney);
            Console.WriteLine(thefinalSpentMoney);
        }
    }
}
