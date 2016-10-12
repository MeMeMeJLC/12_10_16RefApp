namespace _12_10_16_production_ref_portal_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        TeamId = c.Int(nullable: false),
                        GameTeam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .ForeignKey("dbo.GameTeams", t => t.GameTeam_Id)
                .Index(t => t.TeamId)
                .Index(t => t.GameTeam_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "GameTeam_Id", "dbo.GameTeams");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "GameTeam_Id" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.Players");
        }
    }
}
