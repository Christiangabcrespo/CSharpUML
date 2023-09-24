using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Administrative
    {
        string name;
        string lastname;
        string function;

        public string Name { get { return name; } }
        public string Lastname { get { return lastname; } }
        public string Function { get { return function; } }

        public Administrative(string name, string lastname, string functiom)
        {
            this.name = name;
            this.lastname = lastname;
            this.function = function;
        }
        public override string ToString()
        {
            return "Nombre: " + name + " " + lastname + ", Funcion: " + function + ".";
        }
    }
}
