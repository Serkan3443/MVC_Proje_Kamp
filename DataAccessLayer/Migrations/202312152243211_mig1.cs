namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Iceriks", "YazarID", c => c.Int());
            CreateIndex("dbo.Iceriks", "YazarID");
            AddForeignKey("dbo.Iceriks", "YazarID", "dbo.Yazars", "YazarID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Iceriks", "YazarID", "dbo.Yazars");
            DropIndex("dbo.Iceriks", new[] { "YazarID" });
            DropColumn("dbo.Iceriks", "YazarID");
        }
    }
}
