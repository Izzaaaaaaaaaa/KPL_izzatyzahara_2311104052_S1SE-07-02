using System;

class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Izzaty"); // Ganti dengan nama panggilanmu

        Console.ReadLine(); // Agar console tidak langsung tertutup
    }
}
