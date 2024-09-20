namespace Program;

public class Arma
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }

    public Arma(string nombre, int ataque)
    {
        this.Nombre = nombre;
        this.Ataque = ataque;
    }
}