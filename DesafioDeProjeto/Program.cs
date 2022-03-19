using System; 
using DesafioDeProjeto.src.entities;
class Program {

    static void Main(string[] args) { 

        Character character = new Knight("Arus", 23, "Knight");
        
        
        Console.WriteLine(character.HeroType);
        Console.WriteLine(character.Attack(5));
    }
}