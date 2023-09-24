using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Club club1 = new Club("Barcelona", "Calle falsa", 123, "springfield", 2005);
            Coach entrenador1 = new Coach("Pep", "Guardiola", Coach.Tactic.OFFENSIVE);
            Coach entrenador2 = new Coach("Josep", "Mourinho", Coach.Tactic.DEFENSIVE);
            Coach entrenador3 = new Coach("Lionel", "Scaloni", Coach.Tactic.BALANCED);
            Team equipo = new Team(Team.Category.FIRST, entrenador1);
            Team equipo2 = new Team(Team.Category.SECOND, entrenador2);
            Team equipo3 = new Team(Team.Category.THIRD, entrenador3);
            Player jugador1 = new Player("Osvaldo", "Armiento", 21);
            Player jugador2 = new Player("Adam", "Bareiro", 54);
            Player jugador3 = new Player("Perrito", "Barrio", 7);
            Player jugador4 = new Player("Emiliano", "Martínez", 23);
            Player jugador5 = new Player("Kevin", "De Bruyne", 12);
            Player jugador6 = new Player("Josip", "Stanisic", 88);
            Administrative administrativo1 = new Administrative("Elias", "Herrera", "Relaciones Publicas");
            Administrative administrativo2 = new Administrative("Martin", "Demichelis", "Community Manager");
            Administrative administrativo3 = new Administrative("Christian", "Olmos", "Analista financiero");
           
            equipo.AddPlayers(jugador1);
            equipo.AddPlayers(jugador2);
            equipo2.AddPlayers(jugador3);
            equipo2.AddPlayers(jugador4);
            equipo3.AddPlayers(jugador5);
            equipo3.AddPlayers(jugador6);
            club1.AddTeam(equipo);
            club1.AddTeam(equipo2);
            club1.AddTeam(equipo3);
            club1.AddAdministrative(administrativo1);
            club1.AddAdministrative(administrativo2);
            club1.AddAdministrative(administrativo3);
            Console.WriteLine(club1.ToString());
            Console.WriteLine("");
            
            equipo.RemovePlayers(jugador1);
            equipo2.RemovePlayers(jugador3);
            Console.WriteLine(club1.ShowTeamList());
            Console.WriteLine("");

            club1.RemoveTeam(equipo2);
            club1.RemoveAdministrative(administrativo3);

            Console.WriteLine(club1.ToString());
            Console.ReadKey();
        }
    }
}
