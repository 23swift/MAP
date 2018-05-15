namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addApprovalSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApprovalSetup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprovalCount = c.Int(nullable: false),
                        Rank = c.String(),
                        WithRequirements = c.Boolean(nullable: false),
                        WithException = c.Boolean(nullable: false),
                        RequestType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApprovalSetup");
        }
    }
}
