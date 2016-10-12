using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class Substitution
    {
        public int Id { get; set; }
        public int GoingOffTheFieldId { get; set; }
        public int GoingOnTheFieldId { get; set; }
        public TimeSpan SubstitutionTime { get; set; }

        public GamePlayer GoingOffTheField { get; set; }
        public GamePlayer GoingOnTheField { get; set; }
    }
}