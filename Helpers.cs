namespace MathGame;

public static class Helpers
{

  public static bool CheckGameSelectionIsValid(string userInput)
  {

    bool isNumeric = int.TryParse(userInput, out int result);

    if (isNumeric)
    {
      return true;
    }
    else
    {
      Console.WriteLine("You must enter a number between 1 and 5");
      return false;
    }

  }

  public static bool CheckAnswerIsValid(string userInput)
  {
    bool isNumeric = int.TryParse(userInput, out int result);

    if (isNumeric)
    {
      return true;
    }
    else
    {
      Console.WriteLine("You must enter a number between 1 and 5");
      return false;
    }


  }


}