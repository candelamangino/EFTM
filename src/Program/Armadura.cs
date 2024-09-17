namespace Program;

public class Armadura
{
    public string Nombre { get; set; }
    public int Defensa { get; set; }

    public Armadura(string nombre, int defensa)
    {
        this.Nombre = nombre;
        this.Defensa = defensa;
    }
}