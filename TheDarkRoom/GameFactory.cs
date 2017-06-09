using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkRoom
{
    class GameFactory
    {
        public static PlayerCharacter create(string type)
        {
            Console.Clear();
            Console.WriteLine("Please name your character:");

            string name = Console.ReadLine();

            if(String.IsNullOrEmpty(name))
            {
                GameFactory.create(type);
            }

            return new Character(name);
        }
    }
}
