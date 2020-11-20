namespace auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Services", "ServiceType", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "ServiceType", c => c.String());
            AlterColumn("dbo.Services", "Name", c => c.String());
        }
    }
}
