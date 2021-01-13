using System;

namespace Zadanie32
{
    class Program
    {
        static void Main(string[] args)
        {
            var wylosowanaLiczba = Gra.GeneratorLiczb();
            Console.WriteLine("Zgadnij jaką liczbę wylosował komputer?");
            Gra.Weryfikacja(wylosowanaLiczba);
        }
    }
}
