namespace math_game_v2;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        GameEngine Game = new GameEngine();

        Game.Start();
        Game.Play();

    }
}
