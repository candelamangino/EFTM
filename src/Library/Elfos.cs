namespace Library;

public class Elfos
{
    public string Name { get; set; }
    public int Life { get; set; }
    public Gun gun;
    public Club club;

    public Elfos(string name, int life, Gun gun_, Club club_)
    {
        Name = name;
        Life = life;
        gun = gun_;
        club = club_;
    }

    public int GetAttackVakue()
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

    public int GetDefenseValue()
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
            int attack = GetAttackVakue();
            int defenseContrincante = contrincante.GetDefenseValue();

            int daño = attack - defenseContrincante;

            contrincante.Life -= daño;
            Console.WriteLine(
                $"{Name} ataca a {contrincante.Name}, y le hace {daño} daño y queda con {contrincante.Life} vidas");
        }
    }

    public void Heal(int cantidad)
        {
            Life += cantidad;
            Console.WriteLine($"{Name} se curo y ahora tiene {Life} vidas");
        }
    
}