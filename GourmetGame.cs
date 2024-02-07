namespace JogoGourmet
{
    class GourmetGame
    {
        public GourmetGame()
        {
            tree_ = new Node("massa")
            {
                Left = new Node("Bolo de chocolate"),
                Right = new Node("Lasanha")
            };
        }

        public void Start()
        {
            var currentNode = tree_;
            Console.WriteLine("Pense em um prato que você gosta.");
            while (true)
            {
                Console.WriteLine($"O prato que você pensou é {currentNode.Data}? (pressione a tecla [S] para Sim ou [N] para Não)");
                var pressedKey = Console.ReadKey().Key;
                Console.WriteLine();
                while (pressedKey != ConsoleKey.S && pressedKey != ConsoleKey.N)
                {
                    Console.WriteLine("Por gentileza, pressione a tecla [S] para Sim ou [N] para Não");
                    pressedKey = Console.ReadKey().Key;
                    Console.WriteLine();
                }
                if (pressedKey == ConsoleKey.N)
                {
                    if (currentNode.Left is not null)
                        currentNode = currentNode.Left;
                    else
                    {
                        Console.WriteLine("Desisto.");
                        UpdateTree(currentNode.Data);
                        break;
                    }
                }
                else if (pressedKey == ConsoleKey.S)
                {
                    if (currentNode.Right is not null)
                        currentNode = currentNode.Right;
                    else
                    {
                        Console.WriteLine("Acertei.");
                        break;
                    }
                }
            }
        }

        private void UpdateTree(string lastDishNameThatWasGuessed)
        {
            Console.WriteLine("Qual prato você pensou?");
            var newDishName = Console.ReadLine()?.Trim();
            while (string.IsNullOrWhiteSpace(newDishName))
            {
                Console.WriteLine("Por gentileza, informe qual prato você pensou.");
                newDishName = Console.ReadLine()?.Trim();
            }
            Console.WriteLine($"Qual característica o prato {newDishName} possui que o diferencia do prato {lastDishNameThatWasGuessed}?");
            var newDishTrait = Console.ReadLine()?.Trim();
            while (string.IsNullOrWhiteSpace(newDishTrait))
            {
                Console.WriteLine($"Por gentileza, informe qual característica o prato {newDishName} possui que o diferencia do prato {lastDishNameThatWasGuessed}.");
                newDishTrait = Console.ReadLine()?.Trim();
            }
            tree_ = new Node(newDishTrait)
            {
                Left = tree_,
                Right = new Node(newDishName)
            };

        }

        private Node tree_;
    }
}
