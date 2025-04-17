using System;
using modul7_kelompok_5;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [3] Menampilkan Parsing Glossary Item ===");
        var glossaryItem= new GlossaryItem2311104052();
        glossaryItem.ReadJSON();
        Console.ReadLine();
    }
}