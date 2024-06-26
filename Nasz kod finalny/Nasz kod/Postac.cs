
abstract class Postac
{
    public char Ikonka { get; set; }
    public int MaxPz { get; private set; } = 100;
    public int Pz { get; set; }
    public Punkt Pozycja { get; set; }
    public Punkt PoprzedniaPozycja { get; set; }

    public Postac(char ikonka, Punkt startowaPozycja)
    {
        Ikonka = ikonka;
        Pz = MaxPz;
        Pozycja = new Punkt(startowaPozycja);
        PoprzedniaPozycja = new Punkt(startowaPozycja);
    }

    public abstract Punkt WezNastepnaPozycje();

    public void Ruch(Punkt nowaPozycja)
    {
        PoprzedniaPozycja = new Punkt(Pozycja);
        Pozycja = nowaPozycja;
    }

    public bool IsAdjacent(Postac other)
    {
        int deltaX = Math.Abs(this.Pozycja.X - other.Pozycja.X);
        int deltaY = Math.Abs(this.Pozycja.Y - other.Pozycja.Y);
        return (deltaX <= 1 && deltaY <= 1);
    }

    public bool CzyZyje()
    {
        if(Pz <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
