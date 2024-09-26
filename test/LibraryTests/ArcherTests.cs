namespace LibraryTests;

using Library;
public class ArcherTests
{
    [Test]
    public void TestArcher()
    {
        // Arrange
        Gun bow = new Gun("Bow", 10);
        Armor lighArmor = new Armor("Light Armor", 5);

        // Crear personaje Archer
        Archer arqueromagico = new Archer("Arquero Mágico", 100, bow, lighArmor);

        // Crear otro personaje del mismo tipo (Archer) para simular una pelea
        Gun crossbow = new Gun("Crossbow", 12);
        Armor heavyArmor = new Armor("Heavy Armor", 8);
        Archer megaarquero = new Archer("Mega Arquero", 120, crossbow, heavyArmor);

        // Act
        // Arquero Mágico ataca a Mega Arquero
        arqueromagico.Attack(megaarquero);

        // Assert
        Assert.AreEqual(118, megaarquero.Health);

    }
}