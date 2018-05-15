namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmailAddTorequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Request", "eMail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Request", "eMail");
        }
    }
}
