using System.Net.NetworkInformation;

namespace MathGame;

public static class GameEngine
{
  public static int UserChoice;
  public static void Start()
  {
    Console.Clear();
    Console.WriteLine(@"Hello and welcome to the math game. Please select a game from the options below:

    1. Addition
    2. Subtraction
    3. Multiplication
    4. Division
    5. Quit

    ");
  }

  public static int GetUserGameChoice()
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

    UserChoice = Convert.ToInt32(choice);
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
        SubtractionGameLogic.Launch();
        break;
      case 3:
        MultiplicationGameLogic.Launch();
        break;
      case 4:
        DivisionGameLogic.Launch();
        break;
    }
  }

  public static void EndGame()
  {
    Console.WriteLine($"Game over! You answered {Status.currentScore} out of 10 questions correctly");
    Console.WriteLine("Would you like to play again? (y/n)");

    bool inputIsValid = false;

    while (!inputIsValid)
    {

      string? input = Console.ReadLine();

      if (input == "y")
      {
        Status.questionsAsked = 0;
        Status.currentScore = 0;
        inputIsValid = true;
        Play(UserChoice);
      }
      else if (input == "n")
      {
        Status.questionsAsked = 0;
        Status.currentScore = 0;
        inputIsValid = true;
        Start();
      }
      else
      {
        Console.WriteLine("Please enter y or n");
      }
    }
  }
}