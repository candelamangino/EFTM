namespace Library;

public class Wizard : ICharacter
{
    //responsabilidades de conocer
    public string Name { get; }
     // conocer su nombre
    public int Health { get; set; }     //conocer las vidas que le quedan
    public Baston baston;
    public LibroDeHechizos libro_de_hechizos;
    public int MaxHealth { get; private set; }
    
    
    public Wizard(string name, int health, Baston baston_, LibroDeHechizos libroDeHechizos_)
    {
         
        this.Name = name;
        this.Health = health;
        baston = baston_;
        libro_de_hechizos = libroDeHechizos_;
        this.MaxHealth = health;


    }
    
    //responsabillidades de hacer
    
    public int ObtainAttackValue() //para saber el valor de ataque
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
    public int ObtainDefenseValue()
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

    public void Attack(ICharacter objective) //atacar al otro mago
    {
        if (objective != null)
        {
            int attack = ObtainAttackValue();  //el ataque que se le va a hacer al otro
            int defenseContrincante = objective.ObtainDefenseValue(); //la defensa del otro lo que vale

            int daño = attack - defenseContrincante; //el daño que se le hace al otro
         //   if (daño < 0) daño = 0; //para que el daño no sea negativo pero ¿ puede ser negativo o no?

         objective.Health -= daño; //le baja la vida al otro con el ataque que le hice
         Console.WriteLine($"{Name} ataca a {objective.Name}, y le hace {daño} daño y queda con {objective.Health} vidas.");
        }
    }


    public void Heal() // para que se pueda curar
    {
        Health = MaxHealth; //esto hace que cuando se cura aumente la vida
        Console.WriteLine($"{Name} se curo y ahora tiene {Health} vidas.");
    }
}