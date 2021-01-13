using System;
using System.Collections.Generic;
using System.Text;

namespace footballManager1
{
    class Team
    {
        public Team()
        {

        }

        public Team(string name, int strenght, string stadium, Manager manager) : this()
        {
            this.Name = name;
            this.Strenght = strenght;
            this.HomeStadium = stadium;
            this.Manager = manager;
        }

        public string Name { get; set; }
        public int Strenght { get; set; }
        public string HomeStadium { get; set; }
        public Manager Manager { get; set; }

        // Add lists for player
        public List<Player> Players { get; set; }
    }
}
