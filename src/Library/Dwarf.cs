namespace Library;

public class Dwarf
{
    public string Nombre { get; }
    public Gun Gun { get; set; }
    public int Vida { get; set; }
    public int VidaMaxima { get; private set; }
    public Escudo Escudo { get; set; }

    public Dwarf(string nombre, Gun gun, int vida, Escudo escudo)
    {
        this.Nombre = nombre;
        this.Gun = gun;
        this.Vida = vida;
        this.VidaMaxima = vida;
        this.Escudo = escudo;
    }
    public int ObtenerValorAtaque()
    {
        return Gun.Poder;
    }

    public int ObtenerValorDefensa()
    {
        return Escudo.Defensa;
    }

    public void Atacar(Dwarf objetivo)
    {
        int danio = ObtenerValorAtaque() - objetivo.ObtenerValorDefensa();
        if (danio < 0)
        {
            danio = 0;
        }

        objetivo.Vida -= danio;

        if (objetivo.Vida < 0)
        {
            objetivo.Vida = 0;
        }

        Console.WriteLine($"{Nombre} ataca a {objetivo.Nombre}, causando {danio} de daño. {objetivo.Nombre} tiene ahora {objetivo.Vida} de vida.");
    }

    public void Curar()
    {
        Vida = VidaMaxima;
        Console.WriteLine($"{Nombre} se curó y ahora tiene {Vida} de vida");
    }
}    