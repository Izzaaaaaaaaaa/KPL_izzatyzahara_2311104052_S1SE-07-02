using System;
using modul7_kelompok_5;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [2] Menampilkan Parsing Team Members ===");
        var teamMembers= new TeamMembers2311104052();
        teamMembers.ReadJSON();
        Console.ReadLine();
    }
}