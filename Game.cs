namespace SnakeAttempt
{
    internal class Game
    {
        static int _difficulty;
        static int _consoleWidth;
        static int _consoleHeight;
        static char[,] _gameTiles;
        static bool _running;
        static Game()
        {
            _consoleWidth = Console.WindowWidth;
            _consoleHeight = Console.WindowHeight - 2;
            _gameTiles = new char[_consoleWidth, _consoleHeight];
        }
        public static void Run(int difficulty)
        {
            _difficulty = difficulty;
            _running = true;
            var rng = new Random();
            int spawnX = rng.Next(2, _consoleWidth - 2);
            int spawnY = rng.Next(2, _consoleHeight - 2);
            Thread gameLoop = new Thread(new ThreadStart(DrawGame));
            gameLoop.Start();
        }
        private static void DrawGame() {
            while (_running)
            {
                string lines = "";
                for (int i = 0; i < _gameTiles.GetLength(0); i++)
                {
                    for (int j = 0; j < _gameTiles.GetLength(1); j++)
                    {
                        lines += _gameTiles[i, j];
                    }
                    lines += "\n";
                }
                Console.WriteLine(lines);
                _running = false;
            }
        }
        private static void SpawnPlayer()
        {

        }
        private static void EatFood()
        {

        }
    }
    public class Player
    {
        public int snakeLength;
        public int startX;
        public int startY;
        public int endX;
        public int endY;
        public int xVel;
        Player(int length, int start_X, int start_Y, int end_X, int end_Y)
        {
            snakeLength = length;
            startX = start_X;
            startY = start_Y;
            endX = end_X;
            endY = end_Y;
        }
        public void TurnLeft()
        {

        }
        public void TurnRight()
        {

        }
    }
}
