namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsApprovedField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequiredApproval", "isApproved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RequiredApproval", "isApproved");
        }
    }
}
