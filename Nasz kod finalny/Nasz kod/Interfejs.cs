class Interfejs
{
    public Punkt PoczatekInterfejsu {get;set;}
    public Punkt PozycjaKamery {get;set;}
    private string[] daneInterfejsu;
    public Gracz MaxPz{get;}
    public Interfejs()
    {
        daneInterfejsu = new string[]{
             "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■",
             "■                                                                                                                                                                                                                                         ■",
             "■                                                                                                                                                                                                                                         ■",
             "■                                                                                                                                                                                                                                         ■",
             "■                                                                                                                                                                                                                                         ■",
            $"■                             {MaxPz}                                                                                                                                                                                                     ■",
             "■                                                                                                                                                                                                                                         ■",
             "■                                                                                                                                                                                                                                         ■",
             "■                                                                                                                                                                                                                                         ■",
             "■                                                                                                                                                                                                                                         ■",
             "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■", 
        };
        PoczatekInterfejsu = new Punkt(0, 0);
    }

    public void Wyswietl(Punkt poczatekInterfejsu)
    {
        PoczatekInterfejsu = poczatekInterfejsu;
        Console.CursorTop = poczatekInterfejsu.Y;
        foreach (string wiersz in daneInterfejsu)
        {
            Console.CursorLeft = poczatekInterfejsu.X;
            Console.WriteLine(wiersz);
        }
        Console.WriteLine();
    }

    public void ZresetujKamere(Punkt pozycjaKamery)
    {
        PozycjaKamery = pozycjaKamery;
        Console.CursorTop = pozycjaKamery.Y;
        Console.CursorLeft = pozycjaKamery.X;
    }
}