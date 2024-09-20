namespace Program;

public class Gun
{
    public string Nombre { get; set; }
    public int Ataque { get; set; }

    public Gun(string nombre, int ataque)
    {
        this.Nombre = nombre;
        this.Ataque = ataque;
    }
}