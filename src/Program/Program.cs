namespace Program;

class Program
{
    static void Main()
    {
        Gun salamalecons = new Gun("Salamalecons", 3);
        Escudo armor = new Escudo("Armor", 2);

        Dwarf brokk = new Dwarf("Brokk", salamalecons, 75, armor);

        Gun karambit = new Gun("Salamalecons", 4);
        Escudo shield = new Escudo("Shield", 1);

        Dwarf minidwarf = new Dwarf("Kokemon", karambit, 50, shield);

        brokk.Atacar(minidwarf);
        minidwarf.Curar();

    }
}