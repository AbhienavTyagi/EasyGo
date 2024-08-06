namespace EasyGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "City", c => c.String(nullable: false));
            AddColumn("dbo.Users", "PostalCode", c => c.String(nullable: false));
            AddColumn("dbo.Users", "MobileNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "MobileNumber");
            DropColumn("dbo.Users", "PostalCode");
            DropColumn("dbo.Users", "City");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}
