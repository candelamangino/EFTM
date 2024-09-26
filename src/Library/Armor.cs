namespace Library;

public class Armor : Item
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Armor(string name, int defense)
    {
        this.Name = name;
        this.Defense = defense;
    }
    
    
}