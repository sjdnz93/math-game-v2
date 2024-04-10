using System.Data.Common;

namespace math_game_v2;

public class AdditionGameLogic
{
  static int currentScore = 0;
  static int questionsAsked = 0;

  public static void Launch()
  {

    while (questionsAsked < 10)
    {
      Console.Clear();
      Console.WriteLine("ADDITION GAME!");

      Random rnd = new Random();

      int firstNumber = rnd.Next(0, 11);
      int secondNumber = rnd.Next(0, 11);
      int result = firstNumber + secondNumber;

      Console.WriteLine($"Your score is {currentScore}");
      Console.WriteLine($"What is {firstNumber} + {secondNumber}?");

      bool inputIsValid = false;

      while (!inputIsValid)
      {
        string? userAnswer = Console.ReadLine();

        bool check = Helpers.CheckAnswerIsValid(userAnswer!);

        if (check)
        {
          inputIsValid = true;
          int userResult = Convert.ToInt32(userAnswer);
          if (userResult == result)
          {
            currentScore++;
            questionsAsked++;
          }
          else
          {
            questionsAsked++;
          }
        }

      }

    }

    Console.WriteLine($"Game over! You answered {currentScore} out of 10 questions correctly");
    Console.WriteLine("Would you like to play again? (y/n)");

    string? input = Console.ReadLine();

    if (input == "y")
    {
      questionsAsked = 0;
      currentScore = 0;
      Console.Clear();
      AdditionGameLogic.Launch();
    }
    else if (input == "n")
    {
      Console.Clear();
      GameEngine newGame = new GameEngine();
      newGame.Start();
    } else {
      Console.WriteLine("Please enter y or n");
    }

  }

}