using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        Console.WriteLine($"Selamat datang, {nama}!");

        int[] arr = new int[50];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
                Console.WriteLine($"{i} #$#$");
            else if (i % 2 == 0)
                Console.WriteLine($"{i} ##");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} $$");
            else
                Console.WriteLine(i);
        }

        Console.Write("Masukkan sebuah angka (1-10000): ");
        string input = Console.ReadLine();
        int angka;

        if (int.TryParse(input, out angka) && angka >= 1 && angka <= 10000)
        {
            if (IsPrime(angka))
                Console.WriteLine($"Angka {angka} merupakan bilangan prima");
            else
                Console.WriteLine($"Angka {angka} bukan merupakan bilangan prima");
        }
        else
        {
            Console.WriteLine("Input tidak valid!");
        }

        Console.ReadLine(); 
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
