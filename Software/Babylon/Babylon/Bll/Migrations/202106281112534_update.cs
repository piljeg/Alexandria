namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PickingOutItem", "Literature_Id", "dbo.Literature");
            DropForeignKey("dbo.PickingOutItem", "PickingOut_Id", "dbo.PickingOut");
            DropIndex("dbo.PickingOutItem", new[] { "PickingOut_Id" });
            DropIndex("dbo.PickingOutItem", new[] { "Literature_Id" });
            AddColumn("dbo.Loan", "Finished", c => c.Boolean(nullable: false));
            AddColumn("dbo.Role", "Name", c => c.String());
            AddColumn("dbo.PickingOut", "Description", c => c.String());
            DropColumn("dbo.Role", "RoleName");
            DropTable("dbo.PickingOutItem");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PickingOutItem",
                c => new
                    {
                        PickingOut_Id = c.Int(nullable: false),
                        Literature_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PickingOut_Id, t.Literature_Id });
            
            AddColumn("dbo.Role", "RoleName", c => c.String());
            DropColumn("dbo.PickingOut", "Description");
            DropColumn("dbo.Role", "Name");
            DropColumn("dbo.Loan", "Finished");
            CreateIndex("dbo.PickingOutItem", "Literature_Id");
            CreateIndex("dbo.PickingOutItem", "PickingOut_Id");
            AddForeignKey("dbo.PickingOutItem", "PickingOut_Id", "dbo.PickingOut", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PickingOutItem", "Literature_Id", "dbo.Literature", "Id", cascadeDelete: true);
        }
    }
}
