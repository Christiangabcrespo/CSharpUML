using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        public enum Category
        {
            FIRST,
            SECOND,
            THIRD
        }
        private Category category;

        Coach coach;
        string accumulator = "";
        List<Player> playerList = new List<Player>();

        public string Accumulator { get { return accumulator; } }

        public Team(Category category, Coach coach)
        {
            this.category = category;
            this.coach = coach;
        }
        public void ResetAccumulator()
        {
            accumulator = "";
        }
        public void RemovePlayers(Player player)
        {

            playerList.Remove(player);
        }

        public void AddPlayers(Player player)
        {
            playerList.Add(player);
        }

        public string ShowList()
        {
            ResetAccumulator();
            foreach (var lista in playerList)
            {

                accumulator += lista + "\n";
            }
            return accumulator;
        }
        public override string ToString()
        {
            return "Equipo: \n" +
              "Categoria: \n- " + category + "\njugadores:\n" + ShowList() + coach.ToString();
        }
    }
}
