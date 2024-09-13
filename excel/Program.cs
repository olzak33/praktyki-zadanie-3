using System;
using System.IO;
using System.Text;

class program
{
    static void Main()
    {
        string date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
        string filename = $"users-{date}.txt";

        string[] names = { "Ania", "Kasia", "Basia", "Zosia" };
        string[] surnames = { "Kowalska", "Nowak" };
        Random random = new Random();

        StringBuilder csvfile = new StringBuilder();
        csvfile.AppendLine("LP,Imie,Nazwisko,Rok urodzenia");

        for (int i = 1; i <= 100; i++)
        {
            string name = names[random.Next(names.Length)];
            string surname = surnames[random.Next(surnames.Length)];
            int birthday = random.Next(1990, 2001);
            
            csvfile.AppendLine($"{i} {name} {surname} {birthday}");
        }

        File.WriteAllText(filename, csvfile.ToString() );
        Console.WriteLine($"file {filename} został utworzony");
    }
}