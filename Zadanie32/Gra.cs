using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie32
{
    class Gra
    {
        static public int GeneratorLiczb()
        {
            Random random = new Random();
            int wylosowanaLiczba = random.Next(0, 100);
            return wylosowanaLiczba;
        }

        static public void weryfikacja(int wylosowanaLiczba)
        {
            var licznik = 1;
            var wiadomosc = "";
            uint wpisanaLiczba;
            do
            {
                Console.WriteLine(wiadomosc);
                wpisanaLiczba = uint.Parse(Console.ReadLine());

                wiadomosc = (wpisanaLiczba > wylosowanaLiczba) ?
                    " Liczba jaką podałeś jest zaduża..." :
                    " Liczba jaką podałeś jest zamała...";
                licznik++;

            } while (wpisanaLiczba != wylosowanaLiczba);

            Console.WriteLine($"Brawo! Zgadłeś po {licznik} próbach..... ");
        }


    }

}
