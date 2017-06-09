using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            PlayerCharacter character = GameFactory.create("character");

            Console.WriteLine(character.getName());
        }
    }
}
