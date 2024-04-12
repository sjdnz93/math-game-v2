using System.Data.Common;
using System.Net;

namespace MathGame;

public class AdditionGameLogic
{

  public static void Launch()
  {

    while (Status.questionsAsked < 10)
    {
      Console.Clear();
      Console.WriteLine("ADDITION GAME!");

      Random rnd = new Random();

      int firstNumber = rnd.Next(0, 11);
      int secondNumber = rnd.Next(0, 11);
      int correctAnswer = firstNumber + secondNumber;

      Console.WriteLine($"Your score is {Status.currentScore}\n");
      Console.WriteLine($"Question {Status.questionsAsked + 1} of 10:");
      Console.WriteLine($"{firstNumber} + {secondNumber} = ?");

      bool inputIsValid = false;

      Helpers.ValidateUserAnswer(inputIsValid, correctAnswer);

      }

    Player.UpdateAdditionScores(Status.currentScore);
    GameEngine.EndGame();

  }
}