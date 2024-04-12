namespace MathGame;

public static class Player
{
  static List<int> additionScores = new List<int>();
  static List<int> subtractionScores = new List<int>();
  static List<int> multiplicationScores = new List<int>();
  static List<int> divisionScores = new List<int>();


  public static void ShowScores()
  {
    Console.Clear();
    Console.WriteLine("YOUR GAME SCORES:\n");
    if (additionScores.Count > 0)
    {
      Console.WriteLine($"Addition game scores: {string.Join(", ", additionScores)}");
    }
    else
    {
      Console.WriteLine("You are yet to play the addition game.");
    }

    if (subtractionScores.Count > 0)
    {
      Console.WriteLine($"Subtraction game scores: {string.Join(", ", subtractionScores)}");
    }
    else
    {
      Console.WriteLine("You are yet to play the subtraction game.");
    }

    if (multiplicationScores.Count > 0)
    {
      Console.WriteLine($"Multiplication game scores: {string.Join(", ", multiplicationScores)}");
    }
    else
    {
      Console.WriteLine("You are yet to play the multiplication game.");
    }

    if (divisionScores.Count > 0)
    {
      Console.WriteLine($"Division game scores: {string.Join(", ", divisionScores)}\n");
    }
    else
    {
      Console.WriteLine("You are yet to play the division game.\n");
    }

    Console.WriteLine("Press any key to return to the game menu.");
    Console.ReadKey();
    GameEngine.Start();
  }

  public static void UpdateAdditionScores(int score)
  {
    additionScores.Add(score);
  }

  public static void UpdateSubtractionScores(int score)
  {
    subtractionScores.Add(score);
  }

  public static void UpdateMultiplicationScores(int score)
  {
    multiplicationScores.Add(score);
  }

  public static void UpdateDivisionScores(int score)
  {
    divisionScores.Add(score);
  }

}
