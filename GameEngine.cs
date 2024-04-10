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

      bool check = Helpers.CheckGameSelectionIsValid(input!, this);

      if (check)
      {
        if (userChoice == 5) {
          Console.WriteLine("Goodbye."); 
          Environment.Exit(0);
        }
        inputIsValid = true;
      }
    }
  }

  public void Play()
  {

    switch (userChoice) {
      case 1:
        AdditionGameLogic.Launch();
        break;
      case 2: 
        Console.WriteLine("Subtraction Game");
        break;
      case 3:
        Console.WriteLine("Multiplication Game");
        break;
      case 4:
        Console.WriteLine("Division Game");
        break;       
    }

  }


}