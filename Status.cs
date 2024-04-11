namespace MathGame;

public class Status
{

  public bool GameStatus { get; set; }
  public static int currentScore = 0;
  public static int questionsAsked = 0;

  public Status(bool gameStatus)
  {
    GameStatus = gameStatus;
  }

}
