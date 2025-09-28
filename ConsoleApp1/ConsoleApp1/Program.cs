using System;
using UniqueArtLib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== UniqueArt Console (using UniqueArtLib.dll) ===");
        Console.Write("Enter text to transform: ");
        string input = Console.ReadLine();
        Console.Write("Grid size (odd integer, default 9): ");
        string gs = Console.ReadLine();
        int grid = 9;
        try { if (gs != null && gs.Trim().Length > 0) grid = int.Parse(gs); } catch { grid = 9; }

        ArtisticHashArt art = new ArtisticHashArt();
        art.InputText = input;
        art.GridSize = grid;
        art.Mirror = true;
        art.Author = Environment.UserName; // dấu ấn cá nhân mặc định; đổi thành tên bạn nếu thích

        string result = art.GenerateArt();
        Console.WriteLine();
        Console.WriteLine(result);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
