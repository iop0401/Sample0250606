namespace WebAppSample0250606.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAssetTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Assets", newName: "Asset");
            RenameTable(name: "dbo.Users", newName: "User");
            AddColumn("dbo.Asset", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Asset", "Image");
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Asset", newName: "Assets");
        }
    }
}
