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
            PlayerCharacter player1 = GameFactory.create("character");
            game.addPlayer(player1);
            game.welcomePlayers();

            while(game.continuePlaying() || player1.isAlive())
            {
                string userChoice = game.askChoice();

                if(Convert.ToInt32(userChoice) % 2 == 0)
                {
                    player1.killPlayer();
                }

                if(!player1.isAlive())
                {
                    Console.Clear();
                    Console.WriteLine("YOU DIE!");
                    game.stopPlaying();
                }
            }
        }
    }
}
