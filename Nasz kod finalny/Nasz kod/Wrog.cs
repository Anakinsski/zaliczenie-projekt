class Wrog : Postac
{
    private Random rng;

    public Wrog(char ikonka, Punkt startowaPozycja) : base(ikonka, startowaPozycja)
    {
        rng = new Random();
    }

    public override Punkt WezNastepnaPozycje()
    {
        Punkt nastepnaPozycja = new Punkt(Pozycja);

        nastepnaPozycja.X += rng.Next(-1, 2);
        nastepnaPozycja.Y += rng.Next(-1, 2);

        return nastepnaPozycja;

    }
}