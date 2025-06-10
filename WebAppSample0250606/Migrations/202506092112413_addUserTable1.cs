namespace WebAppSample0250606.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Priorty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Priorty");
        }
    }
}
