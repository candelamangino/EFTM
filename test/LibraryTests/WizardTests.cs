using NUnit.Framework;
using Library;

namespace LibraryTests;

public class WizardTests
{
    [Test]
    public void TestWizard()
    {
        //arrange
        Baston bastonDeFuego = new Baston("Bastón de Fuego", 100);
        Baston bastonDeHielo = new Baston("Bastón de Hielo", 80);
        LibroDeHechizos libroDeHechizos1 = new LibroDeHechizos("Libro de Hechizos Nivel 1", 50);
        LibroDeHechizos libroDeHechizos2 = new LibroDeHechizos("Libro de Hechizos Nivel 2", 70);
        Wizard wizard1 = new Wizard("Gandalf", 100, bastonDeFuego, libroDeHechizos1);
        Wizard wizard2 = new Wizard("Saruman", 120, bastonDeHielo, libroDeHechizos2);

       
       //act
        //aca hago que se peleen 
        wizard1.Attack(wizard2); 
        wizard2.Attack(wizard1);
      //Assert
      Assert.That(wizard1.Vida, Is.EqualTo(45));
        
    }
    
}



