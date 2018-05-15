namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPosRequestTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.POSRequest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestDescription = c.String(),
                        Status = c.Int(nullable: false),
                        WorkflowInstanceId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.POSRequest", "Request_Id", "dbo.Request");
            DropIndex("dbo.POSRequest", new[] { "Request_Id" });
            DropTable("dbo.POSRequest");
        }
    }
}
