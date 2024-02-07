namespace JogoGourmet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gourmetGame = new GourmetGame();
            while (true)
            {
                gourmetGame.Start();
                Console.WriteLine("Você deseja jogar novamente? (pressione a tecla [S] para Sim ou [N] para Não)");
                var pressedKey = Console.ReadKey().Key;
                Console.WriteLine();
                while (pressedKey != ConsoleKey.S && pressedKey != ConsoleKey.N)
                {
                    Console.WriteLine("Por gentileza, pressione a tecla [S] para Sim ou [N] para Não");
                    pressedKey = Console.ReadKey().Key;
                    Console.WriteLine();
                }
                if (pressedKey == ConsoleKey.N)
                    break;
            }
        }
    }
}
