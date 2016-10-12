namespace _12_10_16_production_ref_portal_api.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_12_10_16_production_ref_portal_api.Models._12_10_16_production_ref_portal_apiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_12_10_16_production_ref_portal_api.Models._12_10_16_production_ref_portal_apiContext";
        }

        protected override void Seed(_12_10_16_production_ref_portal_api.Models._12_10_16_production_ref_portal_apiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Games.AddOrUpdate(
                p => p.Description,
                new Game { Description = "Round 1, Game 1", GameDateTime = new DateTime( 2016,10,20)},
                new Game { Description = "Round 1, Game 2", GameDateTime = new DateTime(2016, 10, 24) }
                );

            context.Teams.AddOrUpdate(
                p => p.Name,
                new Team { Name = "Lions", Colour = "Yellow"},
                new Team { Name = "Tigers", Colour = "Orange"},
                new Team { Name = "Lizards", Colour = "Green"},
                new Team { Name = "Gulls", Colour = "White"}
                );

            context.GameTeams.AddOrUpdate(
                p => p.GameId,
                new GameTeam { GameId = 1, TeamId = 1},
                new GameTeam { GameId = 1, TeamId = 2},
                new GameTeam { GameId = 2, TeamId = 3 },
                new GameTeam { GameId = 2, TeamId = 4 }
                );
            
        }
    }
}
