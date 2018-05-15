namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWithRequirementWithException : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Request", "WithRequirements", c => c.Boolean(nullable: false));
            AddColumn("dbo.Request", "WithException", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Request", "WithException");
            DropColumn("dbo.Request", "WithRequirements");
        }
    }
}
