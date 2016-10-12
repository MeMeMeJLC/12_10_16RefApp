using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class Penalty
    {
        public int Id { get; set; }
        public int GamePlayerId { get; set; }
        public int PenaltyTypeId { get; set; }
        public TimeSpan PenaltyTime { get; set; }

        public virtual GamePlayer GamePlayer { get; set; }
        public virtual PenaltyType PenaltyType { get; set; }
    }
}