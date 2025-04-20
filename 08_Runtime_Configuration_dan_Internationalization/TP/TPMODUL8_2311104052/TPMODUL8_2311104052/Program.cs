using System;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine("== Program Cek Suhu & Riwayat Demam ==");

        // Menampilkan input pertama
        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        // Input kedua
        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        bool suhuNormal = false;

        if (config.satuan_suhu == "celcius")
        {
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu == "fahrenheit")
        {
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;
        }

        if (suhuNormal && hariDemam < config.batas_hari_deman)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }

        // Contoh penggunaan method UbahSatuan
        Console.Write("\nIngin mengganti satuan suhu? (y/n): ");
        string pilihan = Console.ReadLine();
        if (pilihan.ToLower() == "y")
        {
            config.UbahSatuan();
            Console.WriteLine($"Satuan suhu sekarang adalah: {config.satuan_suhu}");
            Console.ReadLine();
        }
    }
}
