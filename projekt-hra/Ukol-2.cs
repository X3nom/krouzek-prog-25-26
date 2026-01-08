using System;

namespace SimpleHra
{
    class Program
    {
        static (int, int) GenerateTreasurePosition(int width, int height)
        {
            var random = new Random();

            int x = random.Next(0, width);
            int y = random.Next(0, height);
            return (x, y);
        }

        static void Main(string[] args)
        {
            int width = 9;
            int height = 9;

            int player_x = 0;
            int player_y = 0;

            (int treasure_x, int treasure_y) = GenerateTreasurePosition(width, height);

            int score = 0;

            while (true)
            {
                Console.Clear();

                for (int y = 0; y < height; y++)
                {
                    string row = "";
                    for (int x = 0; x < width; x++)
                    {
                        if (x == player_x && y == player_y)
                        {
                            row = row + "#";
                        }
                        else if (x == treasure_x && y == treasure_y)
                        {
                            row = row + "$";
                        }
                        else
                        {
                            row = row + ".";
                        }

                        row = row + " ";
                    }
                    Console.WriteLine(row);
                }

                Console.WriteLine("Score: " + score);

                string kam = Console.ReadKey().KeyChar.ToString();

                switch (kam)
                {
                    case "w":
                        player_y -= 1;
                        break;
                    case "s":
                        player_y += 1;
                        break;
                    case "a":
                        player_x -= 1;
                        break;
                    case "d":
                        player_x += 1;
                        break;

                    default:
                        Console.WriteLine("Spatny prikaz!");
                        break;
                }

                player_y = (player_y + height) % height;
                player_x = (player_x + width) % width;

                // Check after moving to render the new treasure position right after collecting, without
                // requiring an additional move.
                if (player_x == treasure_x && player_y == treasure_y)
                {
                    score += 1;
                    (treasure_x, treasure_y) = GenerateTreasurePosition(width, height);
                }
            }
        }
    }
}
