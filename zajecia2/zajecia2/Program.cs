using zajecia2;

public class Program
{
    public static void Main(String[] args)
    {
        Kontener kont = new KPlyny(1, 1, 1, 1, 1);
        kont.zaladowanieKontenera(3);
        
        Kontener kont2 = new KGaz(1, 1, 1, 1, 1);
        kont2.zaladowanieKontenera(7);
        Console.WriteLine(kont2.Masa);
    }
}
