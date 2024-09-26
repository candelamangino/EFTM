using Library;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Crear un arma y armadura
            Gun bow = new Gun("Bow", 10);
            Armor lighArmor = new Armor("Light Armor", 5);

            Gun escopeta = new Gun(" Escopeta", 100);
            Gun catana = new Gun("Catana", 100);

            Club garroteDePlastico = new Club("Garrote de plastico", 100);
            Club garroteDeMadera = new Club("Garrote de metal", 100);
            
            // Crear otro personaje del mismo tipo (Archer) para simular una pelea
            Gun crossbow = new Gun("Crossbow", 12);
            Armor heavyArmor = new Armor("Heavy Armor", 8);
            // Archer megaarquero = new Archer("Mega Arquero", 120, crossbow, heavyArmor);
            
            // Arquero Mágico ataca a Mega Arquero
            Archer arqueromagico = new Archer("Arquero Magico", 100, bow, lighArmor);
            Archer megaarquero = new Archer("Mega Arquero", 120, crossbow, heavyArmor);
            arqueromagico.Attack(megaarquero);
            
            // Mega Arquero se cura
            megaarquero.Heal();
            
            // Mega Arquero ataca a Arquero Mágico
            megaarquero.Attack(arqueromagico);
            
            // Arquero Mágico se cura
            arqueromagico.Heal();

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