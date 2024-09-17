using System.Diagnostics;
using Program;

public class ArcherTests
{
    [Test]

    public void TestArcher()
    {
        // Arrange
        Arma bow = new Arma("Bow", 10);
        Armadura lighArmor = new Armadura("Light Armor", 5);

        // Crear personaje Archer
        Archer arqueromagico = new Archer("Arquero Mágico", 100, bow, lighArmor);

        // Crear otro personaje del mismo tipo (Archer) para simular una pelea
        Arma crossbow = new Arma("Crossbow", 12);
        Armadura heavyArmor = new Armadura("Heavy Armor", 8);
        Archer megaarquero = new Archer("Mega Arquero", 120, crossbow, heavyArmor);
        
        
        // Act
        arqueromagico.Atacar(megaarquero);
        
        // Assert
        Assert.That(arqueromagico.Vida, Is.EqualTo(118));
    }
}