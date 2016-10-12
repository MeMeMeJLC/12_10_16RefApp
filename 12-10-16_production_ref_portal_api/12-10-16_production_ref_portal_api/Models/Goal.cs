using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public int GamePlayerId { get; set; }
        public TimeSpan GoalTime { get; set; }
        public bool IsOwnGoal { get; set; }

        public GamePlayer GamePlayer { get; set; }
    }
}