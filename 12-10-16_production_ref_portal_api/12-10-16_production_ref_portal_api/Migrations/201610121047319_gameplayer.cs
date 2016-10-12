namespace _12_10_16_production_ref_portal_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gameplayer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GamePlayers", "IsCaptain", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GamePlayers", "IsCaptain", c => c.Boolean());
        }
    }
}
