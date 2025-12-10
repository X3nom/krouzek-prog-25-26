using System;

namespace SimpleHra
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 9;
            int height = 9;

            int player_x = 0;
            int player_y = 0;

            while (true)
            {
                for(int y = 0; y < height; y++){
                    string row = "";
                    for(int x = 0; x < width; x++){
                        if(x == player_x && y == player_y){
                            row = row + "# ";
                        }
                        else {
                            row = row + ". ";
                        }
                    }
                    Console.WriteLine(row);
                }
                
                Console.Write("kam?: ");
                string kam = Console.ReadLine();

                switch (kam)
                {
                    case "nahoru":
                        player_y -= 1;
                        break;
                    case "dolu":
                        player_y += 1;
                        break;
                    case "doleva":
                        player_x -= 1;
                        break;
                    case "doprava":
                        player_x += 1;
                        break;
                        
                    default:
                        Console.WriteLine("Spatny prikaz!");
                        break;
                }
                
                player_y = (player_y + height)%height;
                player_x = (player_x + width)%width;
            }
        }
    }
}
