class Punkt //Tworzymy klasę "Punkt" (TP)
{
    public int X {get;set;} //Tworzymy klase zmienną "X" (można ją pobierać i ustawiać) Jest publiczna więc z innych plików możemy z niej korzystać.
    public int Y {get;set;} //Tworzymy klase zmienną "X" (można ją pobierać i ustawiać). Jest publiczna więc z innych plików możemy z niej korzystać.

    public Punkt(int x, int y) //Przypisujemy do klasy stworzoną zmienną(TP) "x" i "y", możemy korzystać z nowej zmiennej z "x" i "y", robimy tak zaniamst korzystać z dużego "X" i "Y" bo jakby chyba chcemy żeby duże X i Y nigdy nie miały wartości, idk.
    {
        X = x;
        Y = y;
    }

    public Punkt(Punkt inny) //Przypisujemy do klasy stworzoną zmienną(TP) "inny", możemy korzystać z nowej zmiennej, która ma w sobie dwie nowe zmienne(TP) "inny.X" i "inny.Y" które mają odpowiednio wartośc X która = x która równa się X(get set), z "inny.Y" jest taka sama sytuacja.
    {
        X = inny.X; 
        Y = inny.Y;
    }
}