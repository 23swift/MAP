namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserOnRequiredApproval : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequiredApproval", "User", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RequiredApproval", "User");
        }
    }
}
