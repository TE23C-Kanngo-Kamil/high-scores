Main();

static void Main()
{
    // Lista som lagrar namn och poäng
    List<string> highScores = new List<string>();

    // Loopar tre gånger
    for (int i = 0; i < 3; i++) ;
    {
        Console.WriteLine("Skriv in namn: ");
        string name = Console.ReadLine();

        Console.WriteLine("Skriv in poäng: ");
        string points = Console.ReadLine();

        // Kombinerar namn och poäng
        string entry = $"{name}: {points}";

        // Lägger till i listan
        highScores.Add(entry);

        Console.WriteLine();
    }

    // Skriver ut alla high scores
    Console.WriteLine("=== High Scores ===");
    foreach (string score in highScores)
    {
        Console.WriteLine(score);
    }
    
}