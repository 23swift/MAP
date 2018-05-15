namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miscDbUpdate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.RequiredApprovals", newName: "RequiredApproval");
            RenameTable(name: "dbo.RequestApprovals", newName: "RequestApproval");
            AddColumn("dbo.RequestApproval", "Approver", c => c.String());
            AddColumn("dbo.RequestApproval", "Date", c => c.DateTime());
            AddColumn("dbo.RequestApproval", "Approved", c => c.Boolean(nullable: false));
            DropColumn("dbo.RequestApproval", "ApprovedBy");
            DropColumn("dbo.RequestApproval", "ApprovalDate");
            DropColumn("dbo.RequestApproval", "DeclinedBy");
            DropColumn("dbo.RequestApproval", "DeclineDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RequestApproval", "DeclineDate", c => c.DateTime());
            AddColumn("dbo.RequestApproval", "DeclinedBy", c => c.String());
            AddColumn("dbo.RequestApproval", "ApprovalDate", c => c.DateTime());
            AddColumn("dbo.RequestApproval", "ApprovedBy", c => c.String());
            DropColumn("dbo.RequestApproval", "Approved");
            DropColumn("dbo.RequestApproval", "Date");
            DropColumn("dbo.RequestApproval", "Approver");
            RenameTable(name: "dbo.RequestApproval", newName: "RequestApprovals");
            RenameTable(name: "dbo.RequiredApproval", newName: "RequiredApprovals");
        }
    }
}
