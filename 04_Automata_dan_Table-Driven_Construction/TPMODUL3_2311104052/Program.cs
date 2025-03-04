using TPMODUL3_2311104052;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        kodePos.TampilkanSemuaKodePos();
        DoorMachine pintu = new DoorMachine(); 
        Console.WriteLine(); 

        pintu.BukaPintu();   
        pintu.StatusPintu();

        Console.WriteLine(); 

        pintu.KunciPintu();  
        pintu.StatusPintu(); 

        Console.WriteLine(); 

        pintu.KunciPintu();  
        pintu.BukaPintu();   
    }
}