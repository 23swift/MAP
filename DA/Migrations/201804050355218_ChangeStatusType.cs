namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStatusType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Request", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Request", "Status", c => c.String());
        }
    }
}
