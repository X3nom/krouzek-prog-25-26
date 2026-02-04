class Program
{
    static void Main(string[] args)
    {
        // using var streamReader = new StreamReader("../Hashmap.cs");
        // Console.WriteLine(streamReader.ReadToEnd());

        // Přečteme všechny řádky do seznamu a vypíšeme je s čísly řádků
        // List<string> lines = new List<string>();
        // while (!streamReader.EndOfStream)
        // {
        //     lines.Add(streamReader.ReadLine());
        // }

        // // int pocetCifer = lines.Count.ToString().Length;
        // int pocetCifer = (int)Math.Floor(Math.Log10(lines.Count)) + 1;

        // for (int i = 0; i < lines.Count; i++)
        // {
        //     string line = lines[i];
        //     var strCisloRadku = (i + 1).ToString().PadRight(pocetCifer, ' ');
        //     Console.WriteLine($"{strCisloRadku}| {line}");
        // }

        // using var streamWriter = new StreamWriter("vystup.txt");

        // string line = null;
        // while ((line = Console.ReadLine()) != null)
        // {
        //     streamWriter.WriteLine(line);
        // }

        using StreamReader streamReader = new StreamReader("test_csv.csv")!;

        List<List<string>> entries = new List<List<string>>();
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine()!;
            string[] parts = line.Split(',');

            entries.Add(parts.ToList());
        }


        Console.WriteLine(entries[2][1]);
















        var columnWidths = new int[entries[0].Count];
        for (int i = 0; i < entries.Count; i++)
        {
            for (int j = 0; j < entries[i].Count; j++)
            {
                columnWidths[j] = Math.Max(columnWidths[j], entries[i][j].Length);
            }
        }

        for (int i = 0; i < entries.Count; i++)
        {
            for (int j = 0; j < entries[i].Count; j++)
            {
                string cell = entries[i][j];
                var padded = cell.PadRight(columnWidths[j] + 1, ' ').PadLeft(columnWidths[j] + 2, ' ');

                if (j == entries[i].Count - 1)
                    Console.Write(padded);
                else
                    Console.Write($"{padded} |");
            }
            Console.WriteLine();

            if (i == 0)
            {
                Console.WriteLine(new string('-', columnWidths.Sum()));
            }
        }
    }
}
