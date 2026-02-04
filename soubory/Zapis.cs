using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        // Nacteme tabulku ze souboru
        using StreamReader streamReader = new StreamReader("test_csv.csv")!;

        List<List<string>> entries = new List<List<string>>();
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine()!;
            string[] parts = line.Split(',');

            entries.Add(parts.ToList());
        }
        // Mame nactenou tabulku

        // Ted ji upravime
        entries[2][1] = "8000";

        // Zapiseme upravenou tabulku do noveho souboru

        using StreamWriter streamWriter = new StreamWriter("novy_soubor.csv")!;

        // vice manualni zpusob zapisu
        for(int y = 0; y < entries.Count; y++){
            for(int x = 0; x < entries[y].Count; x++){
                streamWriter.Write(entries[y][x]);
                if(x != entries[y].Count - 1){
                    streamWriter.Write(",");
                }
            }
            streamWriter.WriteLine();
        }        

        // hezci zpusob zapisu
        /*
        for(int y = 0; y < entries.Count; y++){
            streamWriter.WriteLine(String.Join(',', entries[y]));
        }
        */


    }
}
