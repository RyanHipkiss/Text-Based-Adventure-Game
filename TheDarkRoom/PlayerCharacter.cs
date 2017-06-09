using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkRoom
{
    interface PlayerCharacter
    {
        string getName();
        bool isAlive();
        void killPlayer();
    }
}
