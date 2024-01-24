using System;

class Program
{
    static void Main()
    {
        Console.Write("Zagrajmy razem w grę!");
        Console.WriteLine();

        Random r = new Random();
        int winNum = r.Next(0, 100);
        bool win = false;
		int rounds = 0;

        while (!win)
        {
			rounds++;
			Console.WriteLine($"Runda {rounds}");
			
            Console.Write("Zgadnij liczbę pomiędzy 0 a 100: ");
            string s = Console.ReadLine();

			if (s.ToLower() == "Koniec")
			{
			Console.WriteLine("Gra Przerwana...");
				break;
			}
			
			int guess;
			
            if (int.TryParse(s, out guess))
            {
				win = HandleGuess(guess, winNum);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format liczby. Spróbuj ponownie.");
            }

            Console.WriteLine();

        } while (!win);

        Console.WriteLine($"Dziękuję za zagranie w moją grę! <3333 Rozegrane Rundy: {rounds}");
        Console.Write("Wciśnij dowolny przycisk, aby zakończyć grę.");
        Console.ReadKey(true);
    }

    static bool HandleGuess(int guess, int target)
    {
        switch (CompareNumbers(guess, target))
        {
            case 1:
                Console.WriteLine("Zbyt wysoka liczba! Podaj nieco niższą...");
                break;

            case -1:
                Console.WriteLine("Za niska liczba! Podaj nieco wyższą...");
                break;

            case 0:
                Console.WriteLine("Wygrałeś! <3");
                return true;

            default:
                Console.WriteLine("Błąd! Spróbuj ponownie.");
                break;
        }
		return false;
    }

    static int CompareNumbers(int guess, int target)
    {
        return guess.CompareTo(target);
    }
}
