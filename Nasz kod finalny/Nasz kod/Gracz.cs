
class Gracz : Postac
{
  
    private Dictionary<ConsoleKey, Punkt> 
    Kierunki = new Dictionary<ConsoleKey, Punkt>(); //Tworzymy(TP) zmienną "Kierunki" ma wartośc nowego Dictionary("new Dictionary"). Powiązuje ona wciśnięte klawisze(ConsoleKey) z klasą "Punkt"(po to to robimy abyśmy mogli potem przypisać wciśnięty klawisz do koordynatów które się zawierają w klasie "Punkt").

    public Gracz(char ikonka, Punkt startowaPozycja) : base(ikonka, startowaPozycja)//Tworzymy(TP) zmienną "startingPosition", JP - "Punkt".
    {
        Pozycja = new Punkt(startowaPozycja); //Przypisujemy zmiennej "pozycja" wartość nowego punktu, który ma wartość "startingPosition"(jeszcze bez wartości).
        PoprzedniaPozycja = new Punkt(startowaPozycja);//

        Kierunki[ConsoleKey.W] = new Punkt(0, -1); //Przy kliknięciu W(ConsoleKey.W), przywołując klase "Punkt" przypisujemy zmiennej "Kierunki" wartość koordynatów x:0 y:-1.
        Kierunki[ConsoleKey.S] = new Punkt(0, 1); //Przy kliknięciu S, przywołując klase "Punkt" przypisujemy zmiennej "Kierunki" wartość x:0 y:1.
        Kierunki[ConsoleKey.D] = new Punkt(1, 0); //Przy kliknięciu D, przypisujemy zmiennej "Kierunki" wartość x:1 y:0.
        Kierunki[ConsoleKey.A] = new Punkt(-1, 0); //Przy kliknięciu A, przypisujemy wartość x-:1 y:0.
    }
    //Zmienna "Kierunki" może przyjmować tylko wartości koordynatów, przyjmuje je za pomocą biblioteki.

    public override Punkt WezNastepnaPozycje()
    {
        Punkt nastepnaPozycja = new Punkt(Pozycja);
        ConsoleKeyInfo wcisnietyKlawisz = Console.ReadKey(true);
        if (Kierunki.ContainsKey(wcisnietyKlawisz.Key))
        {
            Punkt kierunek = Kierunki[wcisnietyKlawisz.Key];
            nastepnaPozycja.X += kierunek.X;
            nastepnaPozycja.Y += kierunek.Y;
        }
        return nastepnaPozycja;
    }
}