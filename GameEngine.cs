namespace math_game_v2;

public class GameEngine
{

  public int userChoice;

  public GameEngine()
  {
  }

  public void Start()
  {
    Console.WriteLine(@"Hello and welcome to the math game. Please select a game from the options below:

    1. Addition
    2. Subtraction
    3. Multiplication
    4. Division
    5. Quit

    ");

    bool inputIsValid = false;

    while (!inputIsValid)
    {

      string? input = Console.ReadLine();

      bool check = Helpers.CheckInputIsValid(input!, this);

      if (check)
      {
        inputIsValid = true;
      }
    }
  }

  public void Play()
  {
    Console.WriteLine("Play");
    Console.WriteLine(userChoice);
  }


}