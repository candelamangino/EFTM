namespace Library;

public class Elfos : ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int HealthMaxima { get; private set; }
    
    public Gun gun;
    public Club club;

    public Elfos(string name, int health, Gun gun_, Club club_)
    {
        this.Name = name;
        this.Health = health;
        this.gun = gun_;
        this.club = club_;
        this.HealthMaxima = health;
    }
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
            
        Console.WriteLine(this.Name + $" ataca a {Name}, causando " + damage + " de daño. XXX tiene ahora " + objective.Health + " de vida.");

    }

    public void Heal()
    {
        int Health = this.HealthMaxima;
        Console.WriteLine($"{this.Name} se curó y ahora tiene {Health} de vida");
    }



    public int ObtainAttackValue()
    {
        int attackValue = 10;
        if (gun != null)
        {
            attackValue += gun.Attack;
        }

        if (club != null)
        {
            attackValue += club.Poder;
        }

        return attackValue;
    }

    public int ObtainDefenseValue()
    {
        int defenseValue = 5;
        if (gun != null)
        {
            defenseValue += gun.Attack / 2;
        }

        if (club != null)
        {
            defenseValue += club.Poder;
        }

        return defenseValue;
    }

    public void SetGun(Gun newgun)
    {
        if (this.gun == null || newgun.Attack > gun.Attack)
        {
            gun = newgun;
        }
        Console.WriteLine($"Gun actual {gun}");
    }

    public void SetClub(Club newclub)
    {
        if (club == null || newclub.Poder > club.Poder)
        {
            club = newclub;
        }
        Console.WriteLine($"Club actual {club}");
    }

    public void Attack(Elfos contrincante)
    {
        if (contrincante != null)
        {
            int attack = ObtainAttackValue();
            int defenseContrincante = contrincante.ObtainDefenseValue();

            int daño = attack - defenseContrincante;

            contrincante.Health -= daño;
            Console.WriteLine(
                $"{Name} ataca a {contrincante.Name}, y le hace {daño} daño y queda con {contrincante.Health} vidas");
        }
    }

    public void Heal(int cantidad)
        {
            Health += cantidad;
            Console.WriteLine($"{Name} se curo y ahora tiene {Health} vidas");
        }
    
}