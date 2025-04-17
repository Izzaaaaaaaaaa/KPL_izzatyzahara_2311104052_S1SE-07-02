using System;
using modul7_kelompok_5;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [1] Menampilkan Parsing Data Mahasiswa ===");
        var datamahasiswa = new DataMahasiswa2311104052();
        datamahasiswa.ReadJSON();
        Console.ReadLine();
    }
}