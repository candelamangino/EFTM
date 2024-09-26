namespace Library;

public class Dwarf : ICharacter
{
    public string Name { get; }
    public Gun Gun { get; set; }
    public int Health { get; set; }
    public int HealthMaxima { get; private set; }
    public Escudo Escudo { get; set; }

    public Dwarf(string nombre, Gun gun, int health, Escudo escudo)
    {
        this.Name = nombre;
        this.Gun = gun;
        this.Health = health;
        this.HealthMaxima = health;
        this.Escudo = escudo;
    }
    public int ObtainAttackValue()
    {
        return Gun.Attack;
    }

    public int ObtainDefenseValue()
    {
        return Escudo.Defensa;
    }

    // public void Attack(ICharacter contrincante) //atacar al otro mago
    // {
    //     if (contrincante != null)
    //     {
    //         int attack = GetAttackValue();  //el ataque que se le va a hacer al otro
    //         int defenseContrincante = contrincante.GetDefenseValue(); //la defensa del otro lo que vale
    //
    //         int daño = attack - defenseContrincante; //el daño que se le hace al otro
    //         //   if (daño < 0) daño = 0; //para que el daño no sea negativo pero ¿ puede ser negativo o no?
    //
    //         contrincante.Vida -= daño; //le baja la vida al otro con el ataque que le hice
    //         Console.WriteLine($"{Nombre} ataca a {contrincante.Nombre}, y le hace {daño} daño y queda con {contrincante.Vida} vidas.");
    //     }
    // }
    
    public void Attack(ICharacter objective)
    {
        int damage = this.ObtainAttackValue() - objective.ObtainDefenseValue();
        if (damage < 0)
        {
            damage = 0;
        }
    
        objective.Health -= damage;
    
        if (objective.Health < 0)
        {
            objective.Health = 0;
        }
            
        Console.WriteLine(this.Name + " ataca a XXX, causando " + damage + " de daño. XXX tiene ahora " + objective.Health + " de vida.");
    }
    
    public void Heal()
    {
        int Health = this.HealthMaxima;
        Console.WriteLine($"{this.Name} se curó y ahora tiene {Health} de vida");
    }
}    