using System;
using modul7_kelompok_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [1] Menampilkan Parsing Data Mahasiswa ===");
        var dataMahasiswa = new DataMahasiswa2311104052();
        dataMahasiswa.ReadJSON();
        Console.ReadLine();
    }
}