namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequestTypeOnRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Request", "RequestType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Request", "RequestType");
        }
    }
}
