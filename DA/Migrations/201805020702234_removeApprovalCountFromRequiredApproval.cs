namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeApprovalCountFromRequiredApproval : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RequiredApproval", "ApprovalCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RequiredApproval", "ApprovalCount", c => c.Int(nullable: false));
        }
    }
}
