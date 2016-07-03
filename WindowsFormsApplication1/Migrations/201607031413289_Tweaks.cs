namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tweaks : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transaction", "PartNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transaction", "PartNumber", c => c.String());
        }
    }
}
