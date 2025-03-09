using System;

class Program
{
    static void Main()
    {
        // 1. Menerima input satu karakter
        Console.Write("Masukkan satu huruf: ");
        char input = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Pindah ke baris baru

        // 2. Menentukan apakah huruf vokal atau konsonan
        if ("AIUEO".Contains(input))
        {
            Console.WriteLine($"Huruf {input} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {input} merupakan huruf konsonan");
        }

        // 3. Membuat array bilangan genap
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        // 4. Melakukan iterasi dan mencetak elemen array
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");

            Console.ReadLine();
        }
    }
}
