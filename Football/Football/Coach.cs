using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Coach
    {
        public enum Tactic
        {
            DEFENSIVE,
            OFFENSIVE,
            BALANCED
        }
        string name;
        string lastname;
        Tactic tactic;

        public string Name {  get { return name; } }
        public string LastName { get { return lastname; } }

        public Coach(string name, string lastname, Tactic tactic)
        {
            this.name = name;
            this.lastname = lastname;
            this.tactic = tactic;
        }
        public override string ToString()
        {
            return "Entrenador: \n" +
                "- " + name + " " + lastname + ", Tactica: " + tactic + ".";
        }
    }
}
