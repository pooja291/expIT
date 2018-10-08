using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity01
{
    class Program
    {
        static void Main(string[] args)
        {
            FPSGame game = new FPSGame();
            game.FPSGameProperty = "Hello FPS";
            Console.WriteLine(game.FPSGameProperty);

            Character character = new Character();
            character.CharacterProperty = "Hello Character";
            character.FPSGameProperty = game.FPSGameProperty;
            Console.WriteLine(character.CharacterProperty);
            Console.WriteLine(character.FPSGameProperty);

            Inventory inventory = new Inventory();
            inventory.InventoryProperty = "Hello Inventory";
            inventory.CharacterProperty = character.CharacterProperty;
            inventory.FPSGameProperty = game.FPSGameProperty;
            Console.WriteLine(inventory.InventoryProperty);
            Console.WriteLine(inventory.CharacterProperty);
            Console.WriteLine(inventory.FPSGameProperty);

            Console.ReadLine();
        }
    }
}