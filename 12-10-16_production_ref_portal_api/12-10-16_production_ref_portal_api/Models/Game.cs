using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime GameDateTime { get; set; }

        public virtual ICollection<GameTeam> GameTeams { get; set; }
    }
}