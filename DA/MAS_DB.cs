namespace DA
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class MAS_DB : DbContext
    {
        // Your context has been configured to use a 'MAS_DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MerchantAquiringSystemWithWF.MAS_DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MAS_DB' 
        // connection string in the application configuration file.
        public MAS_DB()
            : base("name=MAS_DB")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; 
        public virtual DbSet<Models.Request> Request { get; set; }
        public virtual DbSet<Models.POSRequest> POSRequest { get; set; }
        public virtual DbSet<Models.MAEF> MAEF { get; set; }
        public virtual DbSet<Models.Branch> Branch { get; set; }
        public virtual DbSet<Models.ApprovalSetup> ApprovalSetup { get; set; }
        

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}