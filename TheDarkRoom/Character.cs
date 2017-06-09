using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDarkRoom
{
    class Character
    {
        public string name;
        private string className;
        private int age;

        public Character(string name)
        {
            this.name = name;
        }

        public void setClass(string className)
        {
            this.className = className;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
