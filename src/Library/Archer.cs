namespace Library;
public class Archer : ICharacter
{
    public string Name { get; }
    public Gun Gun { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; private set; } // Se utiliza en este caso para curar al personaje
    public Armor Armor { get; set; }
        
    
    public Archer(string name, int health, Gun gun, Armor armor)
    {
        this.Name = name;
        this.Health = health;
        this.Gun = gun;
        this.Armor = armor;
        this.MaxHealth = health; // De esta forma puedo guardar la vida inicial para curar al personje
    }
    
    public int ObtainAttackValue()
    {
        return Gun.Attack;
    }
    
    public int ObtainDefenseValue()
    {
        return Armor.Defense;
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
            
        Console.WriteLine($"{Name} ataca a {objective.Name}, causando {damage} de daño. {objective.Name} tiene ahora {objective.Health} de vida.");
    }
    
    public void Heal()
    {
        Health = MaxHealth;
        Console.WriteLine($"{Name} se curó y ahora tiene {Health} de vida");
    }
}