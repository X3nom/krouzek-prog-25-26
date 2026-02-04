class Program
{
    static void Main(string[] args)
    {
        int width = 20;
        int height = 20;

        bool[,] sand = new bool[height, width];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                sand[y, x] = false;
            }
        }

        SandGenerator sandGenerator = new SandGenerator();
        sandGenerator.AddGenerator(10, 18);

        int count = 0;
        while (true)
        {
            count++;
            count = count % 7;

            if (count == 0)
            {
                foreach (var (genX, genY) in sandGenerator.generatorPositions)
                {
                    sand[genY, genX] = true;
                }
            }

            // Fyzika písku - zpracováváme od spodu nahoru (nízké y = spodek obrazovky)
            for (int y = 1; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (sand[y, x] == true)
                    {
                        // Písek padá dolů (k nižšímu y)
                        if (sand[y - 1, x] == false)
                        {
                            sand[y, x] = false;
                            sand[y - 1, x] = true;
                        }
                        else if (x > 0 && sand[y - 1, x - 1] == false)
                        {
                            sand[y, x] = false;
                            sand[y - 1, x - 1] = true;
                        }
                        else if (x < width - 1 && sand[y - 1, x + 1] == false)
                        {
                            sand[y, x] = false;
                            sand[y - 1, x + 1] = true;
                        }
                    }
                }
            }

            // Vykreslení - od vrchu obrazovky (vysoké y) dolů (nízké y)
            for (int y = height - 1; y >= 0; y--)
            {
                for (int x = 0; x < width; x++)
                {
                    if (sand[y, x] == true)
                    {
                        Console.Write("o ");
                    }
                    else if (sandGenerator.generatorPositions.Contains((x, y)))
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Thread.Sleep(500);
            Console.Clear();
        }
    }
}

class SandGenerator
{
    public List<(int, int)> generatorPositions = new List<(int, int)>();

    public void AddGenerator(int x, int y)
    {
        generatorPositions.Add((x, y));
    }
}
