using System;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Punkt graczaPozycja = new Punkt(10, 3);

        Gracz protagonista = new Gracz('☻', graczaPozycja);
        Wrog troll = new Wrog('T', new Punkt(4, 6));

        Postac[] postacie = new Postac[]
        {
            protagonista,
            troll,
        };

        Mapa mapa = new Mapa();
        Console.Clear();
        mapa.Wyswietl(new Punkt(15, 2));

        Interfejs interfejs = new Interfejs();
        interfejs.Wyswietl(new Punkt(1, 52));
        interfejs.ZresetujKamere(new Punkt(0, 0));

        foreach (Postac postac in postacie)
        {
            mapa.NarysujObiektW(postac.Ikonka, postac.Pozycja);
        }

        while (true)
        {
            foreach (Postac postac in postacie)
            {
                if (postac.Pz <= 0)
                {
                    // Jeśli postać jest pokonana, pomiń jej ruch
                    continue;
                }

                Punkt nastepnaPozycja = postac.WezNastepnaPozycje();
                if (mapa.CzyPunkJestPoprawny(nastepnaPozycja))
                {
                    postac.Ruch(nastepnaPozycja);

                    var poprzedniaKomórka = mapa.WezGrafikeKomorkiZ(postac.PoprzedniaPozycja);
                    mapa.NarysujObiektW(poprzedniaKomórka, postac.PoprzedniaPozycja);
                    mapa.NarysujObiektW(postac.Ikonka, postac.Pozycja);
                }
            }

            // Sprawdź, czy protagonist i inny protagonista są obok siebie i wywołaj atak
            if (protagonista.IsAdjacent(troll))
            {
                Walka.Atak(protagonista, troll, mapa);
            }
            else
            {
                // Usuń poprzednią informację
                Console.SetCursorPosition(0, 21); 
                Console.WriteLine(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, 22); 
                Console.WriteLine(new string(' ', Console.WindowWidth));
            }
        }
    }
}
