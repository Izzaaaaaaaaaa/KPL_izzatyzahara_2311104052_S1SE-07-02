using System;
using PusatDataSingleton;

class Program
{
    static void Main()
    {
        var pusat = PusatData.GetInstance();

        pusat.TambahkanData("Andi");
        pusat.TambahkanData("Budi");
        pusat.TambahkanData("Rian");

        Console.WriteLine("Data awal:");
        pusat.PrintSemuaData();

        pusat.HapusSebuahData(2); // hapus "Rian"

        Console.WriteLine("\nData setelah penghapusan:");
        pusat.PrintSemuaData();

        Console.ReadKey();
    }
}
