using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Player
    {
        string name;
        string lastname;
        int number;

        public string Name { get { return name; } }
        public string Lastname { get { return lastname; } }
        public int Number { get { return number; } }

        public Player(string name, string surname, int number)
        {
            this.name = name;
            this.lastname = surname;
            this.number = number;
        }

        public override string ToString()
        {
            return "- " + name + " " + lastname + ", number: " + number + ".";
        }
    }
}
