class Mapa
{
    public Punkt PoczatekMapy {get;set;}
    private int[][] daneMapy;
    private Dictionary<int, char> grafikiKomorki = new Dictionary<int, char>()
    {
        {0, '.'},
        {1, '#'},
        {2, ' '},
    };
    public Mapa()
    {
        daneMapy = new int[][]{
            new int[] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,0,0,0,0,0,0,0,0,0,0,0,0,1,},
            new int[] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,},
        };
        PoczatekMapy = new Punkt(0, 0);
    }
    public void Wyswietl(Punkt poczatekMapy)
    {
        PoczatekMapy = poczatekMapy;
        Console.CursorTop = poczatekMapy.Y;
        for (int y=0; y<daneMapy.Length; y++)
        {
            Console.CursorLeft = poczatekMapy.X;
            for (int x=0; x<daneMapy[y].Length; x++)
            {
                int numerKomorki = daneMapy[y][x];
                char wygladKomorki = grafikiKomorki.GetValueOrDefault(numerKomorki, '?');
                Console.Write(wygladKomorki);
            }
            Console.WriteLine();
        }
    }

    internal int WezKomorke(Punkt punkt)
    {
        return daneMapy[punkt.Y][punkt.X];
    }

    internal char WezGrafikeKomorkiZ(Punkt punkt)
    {
        return grafikiKomorki[WezKomorke(punkt)];
    }
    internal bool CzyPunkJestPoprawny(Punkt punkt)
    {
        if (punkt.Y >= 0 && punkt.Y < daneMapy.Length)
        {
            if (punkt.X >= 0 && punkt.X < daneMapy[punkt.Y].Length)
            {
                if (WezKomorke(punkt) != 1)
                {
                    return true;
                }
            }
        }
        return false;
    }

    internal void NarysujObiektW(char obiekt, Punkt pozycja)
    {
        Console.SetCursorPosition(pozycja.X + PoczatekMapy.X, pozycja.Y + PoczatekMapy.Y);
        Console.Write(obiekt);
    }
}