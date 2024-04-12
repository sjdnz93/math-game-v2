namespace MathGame;

public class DivisionGameLogic
{
  public static void Launch()
  {
    while (Status.questionsAsked < 10)
    {
      Console.Clear();
      Console.WriteLine("DIVISION GAME!");

      Random rnd = new Random();

      float firstNumber = rnd.Next(1, 51);
      float secondNumber = rnd.Next(2, 51);

      while (firstNumber % secondNumber != 0 || secondNumber >= firstNumber) {
        firstNumber = rnd.Next(1, 51);
        secondNumber = rnd.Next(2, 51);
      }

      float correctAnswer = firstNumber / secondNumber;

      Console.WriteLine($"Your score is {Status.currentScore}\n");
      Console.WriteLine($"Question {Status.questionsAsked + 1} of 10:");
      Console.WriteLine($"{firstNumber} / {secondNumber} = ?");

      bool inputIsValid = false;

      Helpers.ValidateUserAnswer(inputIsValid, (int)correctAnswer);

    }

    GameEngine.EndGame();

  }

}
