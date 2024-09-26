namespace Library;

class Program
    {
        static void Main()
        {
            // Crear un arma y armadura
            Gun bow = new Gun("Bow", 10);
            Armor lighArmor = new Armor("Light Armor", 5);

            // Crear personaje Archer
            Archer arqueromagico = new Archer("Arquero Mágico", 100, bow, lighArmor);

            // Crear otro personaje del mismo tipo (Archer) para simular una pelea
            Gun crossbow = new Gun("Crossbow", 12);
            Armor heavyArmor = new Armor("Heavy Armor", 8);
            Archer megaarquero = new Archer("Mega Arquero", 120, crossbow, heavyArmor);

            // Arquero Mágico ataca a Mega Arquero
            arqueromagico.Attack(megaarquero);

            // Mega Arquero se cura
            megaarquero.Heal();
            
            // Mega Arquero ataca a Arquero Mágico
            megaarquero.Attack(arqueromagico);

            // Arquero Mágico se cura
            arqueromagico.Heal();
        }
    }