namespace Program
{
    class Program
    {
        static void Main()
        {
            // Crear bastones
            Baston bastonDeFuego = new Baston("Bastón de Fuego", 100);
            Baston bastonDeHielo = new Baston("Bastón de Hielo", 80);

            // Crear libros de hechizos
            LibroDeHechizos libroDeHechizos1 = new LibroDeHechizos("Libro de Hechizos Nivel 1", 50);
            LibroDeHechizos libroDeHechizos2 = new LibroDeHechizos("Libro de Hechizos Nivel 2", 70);

            // Crear magos (wizards)
            Wizard wizard1 = new Wizard("Gandalf", 100, bastonDeFuego, libroDeHechizos1);
            Wizard wizard2 = new Wizard("Saruman", 120, bastonDeHielo, libroDeHechizos2);

            // Simulación de ataques
            Console.WriteLine("---- COMIENZA LA BATALLA ----");

            wizard1.Attack(wizard2); // Gandalf ataca a Saruman
            wizard2.Attack(wizard1); // Saruman ataca a Gandalf

            // Simulación de curación
            wizard1.Heal(20); // Gandalf se cura
            wizard2.Heal(15); // Saruman se cura

            // Cambiar bastón y libro de hechizos de Saruman
            Baston bastonDeTrueno = new Baston("Bastón de Trueno", 120);
            LibroDeHechizos libroDeHechizos3 = new LibroDeHechizos("Libro de Hechizos Nivel 3", 90);

            wizard2.SetBaston(bastonDeTrueno); // Cambia a un bastón más poderoso
            wizard2.SetLibroDeHechizos(libroDeHechizos3); // Cambia a un libro más poderoso

            // Nuevo ataque después del cambio de equipo
            wizard2.Attack(wizard1); // Saruman ataca nuevamente con nuevo equipo

            Console.WriteLine("---- FIN DE LA BATALLA ----");
     

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
}