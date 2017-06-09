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
            Character player = new Character("Humphrey Wilkins");

            Console.WriteLine(player.name);
        }
    }
}
