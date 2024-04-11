using System.Security.Cryptography.X509Certificates;

namespace MathGame;

class Program
{


  static void Main(string[] args)
  {

    Console.Clear();

    Status Status = new Status(true);

    var gameActive = Status.GameStatus;

    while (gameActive)
    {
      GameEngine.Start();
      var choice = GameEngine.GetUserChoice();

      if (choice == 5) {
        gameActive = false;
      }

      GameEngine.Play(choice);
    }

    Console.WriteLine("Goodbye!");
    Environment.Exit(0);

  }
}
