namespace _12_10_16_production_ref_portal_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gameplayer1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.GamePlayers", new[] { "PlayerId" });
            DropIndex("dbo.GamePlayers", new[] { "GameId" });
            AlterColumn("dbo.GamePlayers", "PlayerId", c => c.Int(nullable: false));
            AlterColumn("dbo.GamePlayers", "GameId", c => c.Int(nullable: false));
            CreateIndex("dbo.GamePlayers", "PlayerId");
            CreateIndex("dbo.GamePlayers", "GameId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.GamePlayers", new[] { "GameId" });
            DropIndex("dbo.GamePlayers", new[] { "PlayerId" });
            AlterColumn("dbo.GamePlayers", "GameId", c => c.Int());
            AlterColumn("dbo.GamePlayers", "PlayerId", c => c.Int());
            CreateIndex("dbo.GamePlayers", "GameId");
            CreateIndex("dbo.GamePlayers", "PlayerId");
        }
    }
}
