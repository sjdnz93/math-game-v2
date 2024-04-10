namespace math_game_v2;

public static class Helpers
{

    public static bool CheckInputIsValid(string userInput, GameEngine game)
  {

    bool isNumeric = int.TryParse(userInput, out int result);

    if(isNumeric) {
      game.userChoice = result;
      return true;
    } else {
      Console.WriteLine("You must enter a number between 1 and 5");
      return false;
    }


  }



}