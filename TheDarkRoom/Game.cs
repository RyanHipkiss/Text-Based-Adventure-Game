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
        private List<PlayerCharacter> players = new List<PlayerCharacter>();
        private List<int> deathPoints = new List<int>();
        private List<int> restartPoints = new List<int>();
        private Dictionary<int, string> points = new Dictionary<int, string>();

        public Game()
        {
            this.generateChoices();
        }

        public void addPlayer(PlayerCharacter character)
        {
            this.players.Add(character);
        }

        public List<PlayerCharacter> getPlayers()
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

        public void welcomePlayers()
        {
            Console.Clear();
            Console.WriteLine("=============");
            Console.WriteLine(String.Join(", ", this.getPlayers().Select(w => w.getName())) + ". You awake to find your self in a dark room!");
            Console.WriteLine("=============");
        }

        public void generateChoices()
        {
            this.generateDeathPoints();
            this.generateRestartPoints();
            this.generatePoints();
        }

        private void generateDeathPoints() { }
        private void generateRestartPoints() { }
        private void generatePoints()
        {
            for(var point = 1; point < 100; point++)
            {
                this.points[point] = "Point" + Convert.ToString(point);
            }
        }

        public string askChoice()
        {
            Console.WriteLine("Time to choose, " + String.Join(", ", this.getPlayers().Select(w => w.getName())));

            Console.WriteLine("============");

            for(var choice = 1; choice < 4; choice++)
            {
                Console.WriteLine(this.points[choice]);
            }

            Console.WriteLine("============");

            return Console.ReadLine();
        }
    }
}
