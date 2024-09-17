namespace Program;

class Program
    {
        static void Main()
        {
            // Crear un arma y armadura
            Arma bow = new Arma("Bow", 10);
            Armadura lighArmor = new Armadura("Light Armor", 5);

            // Crear personaje Archer
            Archer arqueromagico = new Archer("Arquero Mágico", 100, bow, lighArmor);

            // Crear otro personaje del mismo tipo (Archer) para simular una pelea
            Arma crossbow = new Arma("Crossbow", 12);
            Armadura heavyArmor = new Armadura("Heavy Armor", 8);
            Archer megaarquero = new Archer("Mega Arquero", 120, crossbow, heavyArmor);

            // Arquero Mágico ataca a Mega Arquero
            arqueromagico.Atacar(megaarquero);

            // Mega Arquero se cura
            megaarquero.Curar();
            
            // Mega Arquero ataca a Arquero Mágico
            megaarquero.Atacar(arqueromagico);

            // Arquero Mágico se cura
            arqueromagico.Curar();
        }
    }