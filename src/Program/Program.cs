using System;
using System.Reflection;
using Library;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Gun escopeta = new Gun(" Escopeta", 100);
            Gun catana = new Gun("Catana", 100);

            Club garroteDePlastico = new Club("Garrote de plastico", 100);
            Club garroteDeMadera = new Club("Garrote de metal", 100);

            Elfos elfos1 = new Elfos("Penny", 100, escopeta, garroteDeMadera);
            Elfos elfos2 = new Elfos("Stuart", 100, catana, garroteDePlastico);
            
            Console.WriteLine("----COMIENZA LA BATALLA----");

            elfos1.Attack(elfos2);
            elfos2.Attack(elfos1);
            
            elfos1.Heal((20));
            elfos2.Heal(15);

            Gun garroteDeMetal = new Gun("Baston de metal", 120);
            Club torreta = new Club("Torreta", 90);
            
            elfos2.SetGun(garroteDeMetal);
            elfos2.SetClub(torreta);
            
            elfos2.Attack(elfos1);
            
            Console.WriteLine($"----FIN DE LA BATALLA----");
        }
    }
}