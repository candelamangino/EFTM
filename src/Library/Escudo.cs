namespace Program;

public class Escudo
{
    public string Nombre { get; set; }
    public int Defensa { get; set; }

    public Escudo(string nombre, int defensa)
    {
        this.Nombre = nombre;
        this.Defensa = defensa;
    }
}