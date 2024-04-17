namespace MathGame;

public static class Helpers
{

  public static bool CheckGameSelectionIsValid(string userInput)
  {
    bool isNumeric = int.TryParse(userInput, out _);

    if (isNumeric)
    {
      int number = Convert.ToInt32(userInput);
      if (number >= 1 && number <= 5){
        return true;
      } else {
        Console.WriteLine("You must enter a number between 1 and 5");
        return false;
      }  
    }
    else
    {
      Console.WriteLine("You must enter a number between 1 and 5");
      return false;
    }

  }

  public static bool CheckAnswerIsNumeric(string userInput)
  {
    bool isNumeric = int.TryParse(userInput, out _);

    if (isNumeric)
    {
      return true;
    }
    else
    {
      Console.WriteLine("Your answer must be a number!");
      return false;
    }
  }

  public static void ValidateUserAnswer(bool isValid, int answer)
  {
    while (!isValid)
    {
      string? userAnswer = Console.ReadLine();

      bool check = CheckAnswerIsNumeric(userAnswer!);

      if (check)
      {
        isValid = true;
        int userResult = Convert.ToInt32(userAnswer);
        if (userResult == answer)
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

}