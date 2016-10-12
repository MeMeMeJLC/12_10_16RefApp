namespace _12_10_16_production_ref_portal_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class penalty1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Penalties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GamePlayerId = c.Int(nullable: false),
                        PenaltyTypeId = c.Int(nullable: false),
                        PenaltyTime = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GamePlayers", t => t.GamePlayerId)
                .ForeignKey("dbo.PenaltyTypes", t => t.PenaltyTypeId)
                .Index(t => t.GamePlayerId)
                .Index(t => t.PenaltyTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penalties", "PenaltyTypeId", "dbo.PenaltyTypes");
            DropForeignKey("dbo.Penalties", "GamePlayerId", "dbo.GamePlayers");
            DropIndex("dbo.Penalties", new[] { "PenaltyTypeId" });
            DropIndex("dbo.Penalties", new[] { "GamePlayerId" });
            DropTable("dbo.Penalties");
        }
    }
}
