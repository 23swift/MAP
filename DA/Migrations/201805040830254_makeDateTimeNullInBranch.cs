namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeDateTimeNullInBranch : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branch", "dateClosed", c => c.DateTime());
            AlterColumn("dbo.Branch", "CUPTaxExemptExpiryDate", c => c.DateTime());
            AlterColumn("dbo.Branch", "taxExemptFrom", c => c.DateTime());
            AlterColumn("dbo.Branch", "taxExemptTo", c => c.DateTime());
            AlterColumn("dbo.Branch", "DTIBusinessRegDate", c => c.DateTime());
            AlterColumn("dbo.Branch", "SECRegDate", c => c.DateTime());
            AlterColumn("dbo.Branch", "principalDateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Branch", "principalDateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branch", "SECRegDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branch", "DTIBusinessRegDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branch", "taxExemptTo", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branch", "taxExemptFrom", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branch", "CUPTaxExemptExpiryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branch", "dateClosed", c => c.DateTime(nullable: false));
        }
    }
}
