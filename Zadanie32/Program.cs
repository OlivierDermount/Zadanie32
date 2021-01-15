using System;

namespace Zadanie32
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var wylosowanaLiczba = Gra.GeneratorLiczb();
                    Console.WriteLine("Zgadnij jaką liczbę wylosował komputer?");
                    Gra.weryfikacja(wylosowanaLiczba);
                    Console.WriteLine("Gramy dalej? t/n");
                    var takNie = Console.ReadLine();
                    if (takNie == "n") break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
