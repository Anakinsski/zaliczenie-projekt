using System;

class Walka
{
    public static void Atak(Postac atakujacy, Postac cel, Mapa mapa)
    {
        if (atakujacy.IsAdjacent(cel) && cel.CzyZyje() == true)
        {
            int obrazenia = new Random().Next(5, 16); // Losowe obrażenia od 5 do 15
            cel.Pz -= obrazenia;
            Console.SetCursorPosition(0, 21); // Ustawienie kursora na odpowiednią pozycję
            Console.WriteLine($"{atakujacy.Ikonka} zaatakował {cel.Ikonka} i zadał {obrazenia} obrażeń!");

            if (cel.Pz <= 0)
            {
                cel.Pz = 0;
                Console.SetCursorPosition(0, 22);
                Console.WriteLine($"{cel.Ikonka} został pokonany!");

                // Usuń ikonkę pokonanej postaci z mapy
                mapa.NarysujObiektW(mapa.WezGrafikeKomorkiZ(cel.PoprzedniaPozycja), cel.Pozycja);
            }
        }
        else
        {
            if(cel.CzyZyje() == true)
            {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine($"{atakujacy.Ikonka} próbował zaatakować, ale {cel.Ikonka} jest zbyt daleko!");
            }
            else
            {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine(' ');  
            }
        }
    }
}

