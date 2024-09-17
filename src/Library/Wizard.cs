namespace Program;

public class Wizard
{
    //responsabilidades de conocer
    public string Nombre { get; set; } // conocer su nombre
    public int Life { get; set; }     //conocer las vidas que le quedan
    private Baston baston; 
    private LibroDeHechizos libro_de_hechizos;
    
    public Wizard(string nombre, int life, Baston baston_, LibroDeHechizos libroDeHechizos_)
    {
        Nombre = nombre;
        Life = life;
        baston = baston_;
        libro_de_hechizos = libroDeHechizos_;


    }
    
    //responsabillidades de hacer
    public int GetAttackValue() //para saber el valor de ataque
    {
        int attackValue = 10; //puse 10 solo para probar
        if (baston != null)
        {
            attackValue += baston.Poder;
        }

        if (libro_de_hechizos != null)
        {
            attackValue += libro_de_hechizos.Poder;
        }

        return attackValue;
    }
//para saber el valor de defensa
    public int GetDefenseValue()
    {
        int defenseValue = 5; //valor base q invente de defensa
        if (baston != null)
        {

            defenseValue += baston.Poder / 2; //asi la defensa aumenta con el poder del baston
        }

        if (libro_de_hechizos != null)
        {
            defenseValue += libro_de_hechizos.Poder;
        }

        return defenseValue;
    }

     
    
    public void SetBaston(Baston newbaston) //cambiar el baston por uno mejor
    {
        if (this.baston == null || newbaston.Poder > baston.Poder)
        {
            baston = newbaston;
            
        }
        Console.WriteLine($"Baston actual {baston}");
    }

    
    
    public void SetLibroDeHechizos(LibroDeHechizos newlibro_de_hechizos) //cambiar a mejor libro
    {
        if (libro_de_hechizos == null || newlibro_de_hechizos.Poder > libro_de_hechizos.Poder)
        {
            libro_de_hechizos = newlibro_de_hechizos;
        }
        Console.WriteLine($"Libro de hechizos actual {libro_de_hechizos}");
    }

    public void Attack(Wizard contrincante) //atacar al otro mago
    {
        if (contrincante != null)
        {
            int attack = GetAttackValue();  //el ataque que se le va a hacer al otro
            int defenseContrincante = contrincante.GetDefenseValue(); //la defensa del otro lo que vale

            int daño = attack - defenseContrincante; //el daño que se le hace al otro
         //   if (daño < 0) daño = 0; //para que el daño no sea negativo pero ¿ puede ser negativo o no?

         contrincante.Life -= daño; //le baja la vida al otro con el ataque que le hice
         Console.WriteLine($"{Nombre} ataca a {contrincante.Nombre}, y le hace {daño} daño y queda con {contrincante.Life} vidas.");
        }
    }


    public void Heal(int cantidad) // para que se pueda curar
    {
        Life += cantidad; //esto hace que cuando se cura aumente la vida
        Console.WriteLine($"{Nombre} se curo y ahora tiene {Life} vidas.");
    }
    
    
    
    
}