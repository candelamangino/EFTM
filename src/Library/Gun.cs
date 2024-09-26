namespace Library;

public class Gun : Item
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Gun(string name, int attack)
    {
        this.Name = name;
        this.Attack = attack;
    }
}