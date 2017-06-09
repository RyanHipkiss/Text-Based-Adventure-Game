using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkRoom
{
    class Game
    {
        private bool isPlaying = true;
        private List<Character> players = new List<Character>();

        public void addPlayer(Character character)
        {
            this.players.Add(character);
        }

        public List<Character> getPlayers()
        {
            return this.players;
        }

        public bool continuePlaying()
        {
            return this.isPlaying;
        }

        public void stopPlaying()
        {
            this.isPlaying = false;
        }
    }
}
