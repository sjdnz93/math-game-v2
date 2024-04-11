using System.Net.NetworkInformation;

namespace MathGame;

public static class GameEngine
{

  public static int userChoice;



  public static void Start()
  {
    Console.WriteLine(@"Hello and welcome to the math game. Please select a game from the options below:

    1. Addition
    2. Subtraction
    3. Multiplication
    4. Division
    5. Quit

    ");

  }

  public static int GetUserChoice()
  {

    bool inputIsValid = false;
    string choice = "";

    while (!inputIsValid)
    {

      string? input = Console.ReadLine();

      bool check = Helpers.CheckGameSelectionIsValid(input!);

      if (check)
      {
        inputIsValid = true;
        choice = input!;
      }
    }

    return Convert.ToInt32(choice);
  }

  public static void Play(int userChoice)
  {

    switch (userChoice)
    {
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