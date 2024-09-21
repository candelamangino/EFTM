namespace Library;

public class Gun
{
    public string Nombre { get; set; }
    public int Poder { get; set; }

    public Gun(string nombre, int poder)
    {
        Nombre = nombre;
        Poder = poder;
    }
}