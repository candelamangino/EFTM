namespace Program;

public class LibroDeHechizos
{
    public string Nombre { get; set; }
    public int Poder { get; set;}

    public LibroDeHechizos(string nombre, int poder)
    {
        Nombre = nombre;
        Poder = poder;
    }
}