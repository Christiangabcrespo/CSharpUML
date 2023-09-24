using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    internal class Game:App
    {
        public enum Category
        {
            ACTION,
            PUZZLE,
            SIMULATION
        }
        int minimumAge;
        Category softwareCategory;
    }
}
