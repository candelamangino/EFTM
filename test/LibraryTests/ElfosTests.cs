using NUnit.Framework;
using Program;

public class ElfosTests
{
    [Test]

    public void TestElfos()
    {
        Gun escopeta = new Gun("Escopeta", 100);
        Gun catana = new Gun("Catana", 80);
        Club garroteDePlastico = new Club("Garrote de plastico", 50);
        Club garroteDeMadera = new Club("Garrote de madera", 70);
        Elfos elfos1 = new Elfos("Penny", 100);
        Elfos elfos2 = new Elfos("Stuart", 100);

        elfos1.Attack(elfos2);
        elfos2.Attack(elfos1);

        Assert.That(elfos1.Life, Is.EqualTo(45));
    }
}