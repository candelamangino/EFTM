namespace Library;

public class Club
{
    public string Nombre { get; set; }
    public int Poder { get; set; }

    public Club(string nombre, int poder)
    {
        Nombre = nombre;
        Poder = poder;
    }
}