using pusatdatasingleton;
using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            // A. Buat dua variabel singleton
            var data1 = PusatDataSingleton.GetDataSingleton();
            var data2 = PusatDataSingleton.GetDataSingleton();

            // B. Tambahkan data ke data1
            data1.AddSebuahData("Anggota1 - Budi");
            data1.AddSebuahData("Anggota2 - Sari");
            data1.AddSebuahData("Asisten - Rian");

            // C. Print data2
            Console.WriteLine("Data di data2:");
            data2.PrintSemuaData();

            // D. Hapus nama asisten dari data2
            data2.HapusSebuahData(2); // index 2 = "Asisten - Rian"

            // E. Print ulang data1
            Console.WriteLine("\nSetelah penghapusan, data di data1:");
            data1.PrintSemuaData();

            // F. Print jumlah data dari kedua objek
            Console.WriteLine($"\nJumlah data (data1): {data1.GetSemuaData().Count}");
            Console.WriteLine($"Jumlah data (data2): {data2.GetSemuaData().Count}");
        }
    }
}
