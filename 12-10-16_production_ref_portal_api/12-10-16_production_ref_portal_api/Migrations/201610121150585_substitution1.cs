namespace _12_10_16_production_ref_portal_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class substitution1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Substitutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoingOffTheFieldId = c.Int(nullable: false),
                        GoingOnTheFieldId = c.Int(nullable: false),
                        SubstitutionTime = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GamePlayers", t => t.GoingOffTheFieldId)
                .ForeignKey("dbo.GamePlayers", t => t.GoingOnTheFieldId)
                .Index(t => t.GoingOffTheFieldId)
                .Index(t => t.GoingOnTheFieldId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Substitutions", "GoingOnTheFieldId", "dbo.GamePlayers");
            DropForeignKey("dbo.Substitutions", "GoingOffTheFieldId", "dbo.GamePlayers");
            DropIndex("dbo.Substitutions", new[] { "GoingOnTheFieldId" });
            DropIndex("dbo.Substitutions", new[] { "GoingOffTheFieldId" });
            DropTable("dbo.Substitutions");
        }
    }
}
