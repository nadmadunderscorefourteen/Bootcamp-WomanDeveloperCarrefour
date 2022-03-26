using System; 
using DesafioDeProjeto.src.entities;
class Program {

    static void Main(string[] args) { 

        Character character = new Knight("Arus", "Janica", 23, "Knight");
        Wizard wizard = new Wizard("Janica", "Arus", 25, "White Wizard");
        
        
        Console.WriteLine("You are playing with: " + character.HeroType);
        Console.WriteLine("You are playing with: " + wizard.HeroType);
        Console.WriteLine(character.Attack(9));
        Console.WriteLine(wizard.Attack(20));
    }
}