namespace MathGame;

public class SubtractionGameLogic
{

  public static void Launch()
  {

    while (Status.questionsAsked < 10)
    {
      Console.Clear();
      Console.WriteLine("SUBTRACTION GAME!");

      Random rnd = new Random();

      int firstNumber = rnd.Next(0, 11);
      int secondNumber = rnd.Next(0, 11);
      int result = firstNumber - secondNumber;

      Console.WriteLine($"Your score is {Status.currentScore}\n");
      Console.WriteLine($"Question {Status.questionsAsked + 1} of 10:");
      Console.WriteLine($"{firstNumber} - {secondNumber} = ?");

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
            Status.currentScore++;
            Status.questionsAsked++;
          }
          else
          {
            Status.questionsAsked++;
          }
        }

      }

    }

    GameEngine.EndGame();

  }
}
