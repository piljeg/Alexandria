namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QS2MX1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Literature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_Id = c.Int(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Author", t => t.Author_Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoanItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoanId = c.Int(nullable: false),
                        LiteratureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Literature", t => t.LiteratureId, cascadeDelete: true)
                .ForeignKey("dbo.Loan", t => t.LoanId, cascadeDelete: true)
                .Index(t => t.LoanId)
                .Index(t => t.LiteratureId);
            
            CreateTable(
                "dbo.Loan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Started = c.Boolean(nullable: false),
                        Finished = c.Boolean(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ReceiptItem",
                c => new
                    {
                        Receipt_Id = c.Int(nullable: false),
                        Loan_Id = c.Int(nullable: false),
                        Money = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.Receipt_Id, t.Loan_Id })
                .ForeignKey("dbo.Loan", t => t.Loan_Id, cascadeDelete: true)
                .ForeignKey("dbo.Receipt", t => t.Receipt_Id, cascadeDelete: true)
                .Index(t => t.Receipt_Id)
                .Index(t => t.Loan_Id);
            
            CreateTable(
                "dbo.Receipt",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfIssue = c.DateTime(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Employee_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        EMail = c.String(),
                        Password = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Locked = c.Boolean(nullable: false),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Membership",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AuthorisationLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickingInItem",
                c => new
                    {
                        PickingIn_Id = c.Int(nullable: false),
                        Literature_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PickingIn_Id, t.Literature_Id })
                .ForeignKey("dbo.Literature", t => t.Literature_Id, cascadeDelete: true)
                .ForeignKey("dbo.PickingIn", t => t.PickingIn_Id, cascadeDelete: true)
                .Index(t => t.PickingIn_Id)
                .Index(t => t.Literature_Id);
            
            CreateTable(
                "dbo.PickingIn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickingOut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PickingInItem", "PickingIn_Id", "dbo.PickingIn");
            DropForeignKey("dbo.PickingInItem", "Literature_Id", "dbo.Literature");
            DropForeignKey("dbo.ReceiptItem", "Receipt_Id", "dbo.Receipt");
            DropForeignKey("dbo.Receipt", "User_Id", "dbo.User");
            DropForeignKey("dbo.Receipt", "Employee_Id", "dbo.User");
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.Membership", "User_Id", "dbo.User");
            DropForeignKey("dbo.Loan", "User_Id", "dbo.User");
            DropForeignKey("dbo.ReceiptItem", "Loan_Id", "dbo.Loan");
            DropForeignKey("dbo.LoanItem", "LoanId", "dbo.Loan");
            DropForeignKey("dbo.LoanItem", "LiteratureId", "dbo.Literature");
            DropForeignKey("dbo.Literature", "Category_Id", "dbo.Category");
            DropForeignKey("dbo.Literature", "Author_Id", "dbo.Author");
            DropIndex("dbo.PickingInItem", new[] { "Literature_Id" });
            DropIndex("dbo.PickingInItem", new[] { "PickingIn_Id" });
            DropIndex("dbo.Membership", new[] { "User_Id" });
            DropIndex("dbo.User", new[] { "Role_Id" });
            DropIndex("dbo.Receipt", new[] { "Employee_Id" });
            DropIndex("dbo.Receipt", new[] { "User_Id" });
            DropIndex("dbo.ReceiptItem", new[] { "Loan_Id" });
            DropIndex("dbo.ReceiptItem", new[] { "Receipt_Id" });
            DropIndex("dbo.Loan", new[] { "User_Id" });
            DropIndex("dbo.LoanItem", new[] { "LiteratureId" });
            DropIndex("dbo.LoanItem", new[] { "LoanId" });
            DropIndex("dbo.Literature", new[] { "Category_Id" });
            DropIndex("dbo.Literature", new[] { "Author_Id" });
            DropTable("dbo.PickingOut");
            DropTable("dbo.PickingIn");
            DropTable("dbo.PickingInItem");
            DropTable("dbo.Role");
            DropTable("dbo.Membership");
            DropTable("dbo.User");
            DropTable("dbo.Receipt");
            DropTable("dbo.ReceiptItem");
            DropTable("dbo.Loan");
            DropTable("dbo.LoanItem");
            DropTable("dbo.Category");
            DropTable("dbo.Literature");
            DropTable("dbo.Author");
        }
    }
}
