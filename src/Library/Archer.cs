namespace Program;

public class Archer
{
    public string Nombre { get; }
    public Arma Arma { get; set; }
    public int Vida { get; set; }
    public int VidaMaxima { get; private set; } // Se utiliza en este caso para curar al personaje
    public Armadura Armadura { get; set; }
        
    
    public Archer(string nombre, int vida, Arma arma, Armadura armadura)
    {
        this.Nombre = nombre;
        this.Vida = vida;
        this.Arma = arma;
        this.Armadura = armadura;
        this.VidaMaxima = vida; // De esta forma puedo guardar la vida inicial para curar al personje
    }
    
    public int ObtenerValorAtaque()
    {
        return Arma.Ataque;
    }
    
    public int ObtenerValorDefensa()
    {
        return Armadura.Defensa;
    }
    
    public void Atacar(Archer objetivo)
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