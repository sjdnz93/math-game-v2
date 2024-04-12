using System.Security.Cryptography.X509Certificates;

namespace MathGame;

class Program
{
  static void Main(string[] args)
  {

    //Player Player = new Player();

    Status Status = new Status(true);

    var gameActive = Status.GameStatus;

    GameEngine.Start();

    while (gameActive)
    {
      
      var choice = GameEngine.GetUserGameChoice();

      if (choice == 5) {
        Player.ShowScores();
      }

      if (choice == 6) {
        gameActive = false;
      }

      GameEngine.Play(choice);
    }

    Console.WriteLine("Goodbye!");
    Environment.Exit(0);

  }
}
