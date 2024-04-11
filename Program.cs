using System.Security.Cryptography.X509Certificates;

namespace MathGame;

class Program
{
  static void Main(string[] args)
  {

    Status Status = new Status(true);

    var gameActive = Status.GameStatus;

    GameEngine.Start();

    while (gameActive)
    {
      
      var choice = GameEngine.GetUserGameChoice();

      if (choice == 5) {
        gameActive = false;
      }

      GameEngine.Play(choice);
    }

    Console.WriteLine("Goodbye!");
    Environment.Exit(0);

  }
}
