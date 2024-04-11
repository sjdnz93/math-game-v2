namespace math_game_v2;

class Program
{


  static void Main(string[] args)
  {

    Console.Clear();

    GameEngine Game = new GameEngine();
    Status Status = new Status(true);

    var gameActive = Status.GameStatus;

    while (gameActive)
    {
      Game.Start();
      Game.Play();
    }



  }
}
