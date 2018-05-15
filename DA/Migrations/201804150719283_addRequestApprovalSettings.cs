namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequestApprovalSettings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestApprovals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprovedBy = c.String(),
                        ApprovalDate = c.DateTime(),
                        DeclinedBy = c.String(),
                        DeclineDate = c.DateTime(),
                        Rank = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.RequiredApprovals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprovalCount = c.Int(nullable: false),
                        Rank = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequiredApprovals", "Request_Id", "dbo.Request");
            DropForeignKey("dbo.RequestApprovals", "Request_Id", "dbo.Request");
            DropIndex("dbo.RequiredApprovals", new[] { "Request_Id" });
            DropIndex("dbo.RequestApprovals", new[] { "Request_Id" });
            DropTable("dbo.RequiredApprovals");
            DropTable("dbo.RequestApprovals");
        }
    }
}
