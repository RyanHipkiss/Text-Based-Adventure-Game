using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkRoom
{
    class Character : PlayerCharacter
    {
        private string name;
        private bool alive = true;

        public Character(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public bool isAlive()
        {
            return this.alive;
        }

        public void killPlayer()
        {
            this.alive = false;
        }
    }
}
