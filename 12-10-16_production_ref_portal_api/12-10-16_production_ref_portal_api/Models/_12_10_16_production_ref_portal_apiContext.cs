using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace _12_10_16_production_ref_portal_api.Models
{
    public class _12_10_16_production_ref_portal_apiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _12_10_16_production_ref_portal_apiContext() : base("name=_12_10_16_production_ref_portal_apiContext")
        {
        }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.Game> Games { get; set; }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.GameTeam> GameTeams { get; set; }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.Player> Players { get; set; }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.GamePlayer> GamePlayers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.PenaltyType> PenaltyTypes { get; set; }

        public System.Data.Entity.DbSet<_12_10_16_production_ref_portal_api.Models.Goal> Goals { get; set; }
    }
}
