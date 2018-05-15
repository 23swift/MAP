namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMAEFModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MAEF",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        affiliation = c.Int(),
                        tangent = c.String(),
                        requestType = c.Int(),
                        simulInstallment = c.Boolean(),
                        simulDebit = c.Boolean(),
                        currency = c.String(),
                        creditMidCount = c.Int(),
                        debitTidCount = c.Int(),
                        pepList = c.String(),
                        pepListRemarks = c.String(),
                        isDeclined = c.Boolean(),
                        declinedRemarks = c.String(),
                        location = c.Int(),
                        appearance = c.String(),
                        withTelephone = c.Boolean(),
                        isLargeAccount = c.Boolean(),
                        natureOfBusiness = c.String(),
                        mccCorrect = c.Boolean(),
                        personalAccountNo = c.String(),
                        isBdoAccountNo = c.String(),
                        psv = c.String(),
                        isSignatureVerified = c.Boolean(),
                        withRequirementsReview = c.Boolean(),
                        withException = c.Boolean(),
                        midCap = c.String(),
                        payDelay = c.String(),
                        holdoutAmt = c.String(),
                        processedBy = c.String(),
                        approvedBy = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Request", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MAEF", "Request_Id", "dbo.Request");
            DropIndex("dbo.MAEF", new[] { "Request_Id" });
            DropTable("dbo.MAEF");
        }
    }
}
