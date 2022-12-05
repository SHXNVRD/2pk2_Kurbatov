using System.Diagnostics;

namespace pz_17
{
    class Program
    {
        private static int[,] map = new int[25, 25];
        private static int empty = 0;
        private static int medKit = 1;
        private static int buff = 2;
        private static int mob = 3;
        private static int mobHit = 5;
        private static int mobHP = 15;
        private static int player = 4;
        private static int playerHit = 5;
        private static int playerHP = 30;
        private static int playerPositionX = 11;
        private static int playerPositionY = 11;
        private static int countMob = 10;
        private static int countBuff = 7;
        private static int countMove = 0;

        private static void SaveGame()
        {
            using (FileStream fileStream = File.Open(@"D:\Game Save2.txt", FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine($"Здоровье игрока: {playerHP}");
                    streamWriter.WriteLine($"Ходов: {countMove}");
                    streamWriter.WriteLine($"Мобов осталось: {countMob}");

                    for (int y = 0; y < map.GetLength(0); y++)
                    {
                        for (int x = 0; x < map.GetLength(1); x++)
                        {
                            streamWriter.Write(map[y, x] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    
        private static void Healing()
        {
            playerHP = 30;
        }

        private static void Buff()
        {
            countBuff = 6;
            playerHit *= 2;
        }

        private static void Fight()
        {
            int tempMobHP = mobHP;

            while (playerHP > 0 && tempMobHP > 0)
            { 
                playerHP -= mobHit;
                tempMobHP -= playerHit;
            }
            countMob--;
        }

        private static void MedkitsGeneration()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int y = random.Next(0, 25);
                int x = random.Next(0, 25);

                if (map[y, x] == 0)
                    map[y, x] = medKit;
                else
                    --i;
            }
        }

        private static void BuffsGeneration()
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int y = random.Next(0, 25);
                int x = random.Next(0, 25);

                if (map[y, x] == 0)
                    map[y, x] = buff;
                else
                    --i;
            }
        }

        private static void MobsGeneration()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int y = random.Next(0, 25);
                int x = random.Next(0, 25);

                if (map[y, x] == 0)
                    map[y, x] = mob;
                else
                    --i;
            }
        }

        private static void MapGeneration()
        {
            MedkitsGeneration();
            MobsGeneration();
            BuffsGeneration();

        }

        private static void Move()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    if (map[playerPositionY - 1, playerPositionX] == mob)
                        Fight();
                    else if (map[playerPositionY - 1, playerPositionX] == buff)
                        Buff();
                    else if (map[playerPositionY - 1, playerPositionX] == medKit)
                        Healing();
                    map[playerPositionY, playerPositionX] = empty;
                    map[--playerPositionY, playerPositionX] = player;
                    MapUpdate();
                    break;
                case ConsoleKey.S:
                    if (map[playerPositionY + 1, playerPositionX] == mob)
                        Fight();
                    else if (map[playerPositionY + 1, playerPositionX] == buff)
                        Buff();
                    else if (map[playerPositionY + 1, playerPositionX] == medKit)
                        Healing();
                    map[playerPositionY, playerPositionX] = empty;
                    map[++playerPositionY, playerPositionX] = player;
                    MapUpdate();
                    break;
                case ConsoleKey.A:
                    if (map[playerPositionY, playerPositionX - 1] == mob)
                        Fight();
                    else if (map[playerPositionY, playerPositionX - 1] == buff)
                        Buff();
                    else if (map[playerPositionY, playerPositionX - 1] == medKit)
                        Healing();
                    map[playerPositionY, playerPositionX] = empty;
                    map[playerPositionY, --playerPositionX] = player;
                    MapUpdate();
                    break;
                case ConsoleKey.D:
                    if (map[playerPositionY, playerPositionX + 1] == mob)
                        Fight();
                    else if (map[playerPositionY, playerPositionX + 1] == buff)
                        Buff();
                    else if (map[playerPositionY, playerPositionX + 1] == medKit)
                        Healing();
                    map[playerPositionY, playerPositionX] = empty;
                    map[playerPositionY, ++playerPositionX] = player;
                    MapUpdate();
                    break; 
                case ConsoleKey.Escape:
                    SaveGame();
                    Process.GetCurrentProcess().Kill();
                    break;
            }
        }

        private static void StartGame()
        {
            MapGeneration();

            map[playerPositionY, playerPositionX] = player;

            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (map[y, x] == 2)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (map[y, x] == 3)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (map[y, x] == 4)
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    else
                        Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write(map[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nОсталось HP: {playerHP}");
            Console.WriteLine($"Осталось мобов: {countMob}");

            while (true)
                Move();
        }

        private static void MapUpdate()
        {
            countMove++;

            if (countBuff <= 6 && countBuff > 0)
                countBuff--;

            if (countBuff == 0)
                playerHit = 5;

            if (playerHP > 0)
            {
                Console.Clear();

                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        if (map[y, x] == 1)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else if (map[y, x] == 2)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else if (map[y, x] == 3)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else if (map[y, x] == 4)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        else
                            Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.Write(map[y, x] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nОсталось HP: {playerHP}");
                Console.WriteLine($"Осталось мобов: {countMob}");
                Console.WriteLine($"Ходов: {countMove}");
                //if (countBuff < 6 && countBuff > 0)
                //    Console.WriteLine($"До конца действия баффа осталось: {countBuff}");
            }
            else if (countMob == 0)
            {
                Console.Clear();
                Console.WriteLine($"Ты выиграл!!! +5 баллов к БРС");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape)
                    Process.GetCurrentProcess().Kill();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("GAME OVER");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape)
                    Process.GetCurrentProcess().Kill();
            }
        }

        static void Main()
        {
            StartGame();
        }
    }
}