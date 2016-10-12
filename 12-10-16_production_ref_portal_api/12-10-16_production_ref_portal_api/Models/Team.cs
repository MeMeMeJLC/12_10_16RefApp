using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }

        public ICollection<GameTeam> GameTeams { get; set; }

    }
}