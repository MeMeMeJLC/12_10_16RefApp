namespace _12_10_16_production_ref_portal_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goals1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GamePlayerId = c.Int(nullable: false),
                        GoalTime = c.Time(nullable: false, precision: 7),
                        IsOwnGoal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GamePlayers", t => t.GamePlayerId)
                .Index(t => t.GamePlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "GamePlayerId", "dbo.GamePlayers");
            DropIndex("dbo.Goals", new[] { "GamePlayerId" });
            DropTable("dbo.Goals");
        }
    }
}
