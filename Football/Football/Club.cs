using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Club
    {
        string accumulator = "";
        string accumulator2 = "";
        string name;
        Address address;
        int foundingYear;
        List<Team> teamList = new List<Team>();
        List<Administrative> administrativeWorkersList = new List<Administrative>();

        public string Accumulator { get {  return accumulator; } }
        public string Accumulator2 {  get { return accumulator2; } }
        public string Name { get { return name; } }
        public int FoundingYear { get { return foundingYear; } }

        public Club(string name, string street, int number, string city, int foundingYear)
        {
            this.name = name;
            this.address = new Address(street, number, city);
            this.foundingYear = foundingYear;
        }

        public void RemoveTeam(Team team)
        {
            teamList.Remove(team);
        }
        public void AddTeam(Team team)
        {
            teamList.Add(team);
        }
        public void RemoveAdministrative(Administrative administrative)
        {
            administrativeWorkersList.Remove(administrative);
        }
        public void AddAdministrative(Administrative administrative)
        {
            administrativeWorkersList.Add(administrative);
        }
        public string ShowTeamList()
        {
            accumulator = "";

            foreach (var team in teamList)
            {
                accumulator += team + "\n";
            }
            return accumulator;
        }
        public string ShowAdministrativeList()
        {
            accumulator2 = "";

            foreach (var administrative in administrativeWorkersList)
            {
                accumulator2 += administrative + "\n";
            }
            return accumulator2;
        }
        public override string ToString()
        {
            return "Club Details:\n- Name: " + name + "\n - Founding Year: " + foundingYear + "\n - Address: " + address.ToString() + "\n- Team List:\n" + ShowTeamList() + "- Administrative List:\n" + ShowAdministrativeList();
        }
    }
}
