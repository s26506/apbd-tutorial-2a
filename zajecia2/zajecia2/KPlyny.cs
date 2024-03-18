namespace zajecia2;

public class KPlyny : Kontener
{
    private bool niebezpieczny;
    private const string RODZAJ  = "L";
    public KPlyny(int masa, int waga, int wysokosc, int glebokosc, int maksLadownosc) : base(masa, waga, wysokosc, glebokosc, maksLadownosc)
    {
    }
    
    public override void zaladowanieKontenera(int masa)
    {
        Console.WriteLine(masa+1);
    }
    
    
        
    
}