namespace LibraryTests;

public class DwarfTests
{
    [Test]
    public void TestDwarf()
    {
        // Arrange
        Gun salamalecons = new Gun("Salamalecons", 3);
        Escudo armor = new Escudo("Armor", 2);

        Dwarf brokk = new Dwarf("Brokk", salamalecons, 75, armor);

        Gun karambit = new Gun("Salamalecons", 4);
        Escudo shield = new Escudo("Shield", 1);

        Dwarf minidwarf = new Dwarf("Kokemon", karambit, 50, shield);
        
        // Act
        brokk.Atacar(minidwarf);
        
        // Assert
        Assert.That(brokk.Vida, this.EqualTo(48))
    }
}