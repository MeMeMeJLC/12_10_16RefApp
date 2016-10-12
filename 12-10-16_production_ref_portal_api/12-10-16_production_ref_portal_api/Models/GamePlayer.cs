using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class GamePlayer
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public bool IsCaptain { get; set; }

        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
    }
}