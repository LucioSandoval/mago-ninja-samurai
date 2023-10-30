public class Program
{
    static void Main()
    {
         // Crear instancias de las clases
        Wizard wizard = new Wizard("Gandalf");
        Ninja ninja = new Ninja("Naruto");
        Samurai samurai = new Samurai("Kenshin");

        // Realizar acciones con las instancias
        Human target = new Human("Enemy", 100, 10, 20, 100);

        wizard.Attack(target);
        wizard.Heal(target);

        ninja.Attack(target);
        ninja.Steal(target);

        samurai.Attack(target);
        samurai.Meditate();

        // Imprimir el estado final de las instancias
        Console.WriteLine($"Estado final de {wizard.Name}: {wizard.Health} de salud.");
        Console.WriteLine($"Estado final de {ninja.Name}: {ninja.Health} de salud.");
        Console.WriteLine($"Estado final de {samurai.Name}: {samurai.Health} de salud.");
        Console.WriteLine($"Estado final de {target.Name}: {target.Health} de salud."); 
    }
}       
