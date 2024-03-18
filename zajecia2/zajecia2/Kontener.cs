namespace zajecia2;

public abstract class Kontener
{

    public int Masa { get; set; }
    private int waga;
    private int wysokosc;
    private int glebokosc;
    private string kodSer;
    private static int licznik;
    private int maksLadownosc;

    protected Kontener(int masa, int waga, int wysokosc, int glebokosc, int maksLadownosc)
    {
        this.Masa = masa;
        this.waga = waga;
        this.wysokosc = wysokosc;
        this.glebokosc = glebokosc;
        this.maksLadownosc = maksLadownosc;
    }

    public void oproznienieLadunku()
    {
        
    }
    public virtual void zaladowanieKontenera(int masa)
    {
        Masa = 19;
        
    }
    
}