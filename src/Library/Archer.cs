using System.Collections;

namespace Library;

public class Archer : ICharacter
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; private set; } // Se utiliza en este caso para curar al personaje
    public ArrayList Items { get; private set; }
        
    
    public Archer(string name, int health, Gun gun, Armor armor)
    {
        this.Name = name;
        this.Health = health;
        this.Items = new ArrayList();
        this.Items.Add(gun);
        this.Items.Add(armor);
        this.MaxHealth = health; // De esta forma puedo guardar la vida inicial para curar al personje
    }
    
    public int ObtainAttackValue()
    {
        int totalAttack = 0;

        foreach (Item item in Items)
        {
            totalAttack += item.Attack;
        }

        return totalAttack;
    }
    
    public int ObtainDefenseValue()
    {
        int totalDefense = 0;

        foreach (Item item in Items)
        {
            totalDefense += item.Defense;
        }

        return totalDefense;
    }
    
    public void Attack(ICharacter objective)
    {
        int damage = ObtainAttackValue() - objective.ObtainDefenseValue();
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
        Health = MaxHealth;
        Console.WriteLine($"{Name} se curó y ahora tiene {Health} de vida");
    }
}