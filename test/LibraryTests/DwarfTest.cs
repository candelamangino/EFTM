namespace LibraryTests;

using Library;

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
        brokk.Attack(minidwarf);
        
        // Assert
        Assert.That(brokk.Health, Is.EqualTo(75));
    }
}