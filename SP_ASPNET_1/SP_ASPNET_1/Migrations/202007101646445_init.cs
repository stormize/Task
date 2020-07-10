namespace SP_ASPNET_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPost",
                c => new
                    {
                        BlogPostID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        FK_UserId = c.String(maxLength: 128),
                        DateTime = c.DateTime(nullable: false),
                        Content = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.BlogPostID)
                .ForeignKey("dbo.User", t => t.FK_UserId)
                .Index(t => t.FK_UserId);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_UserId = c.String(maxLength: 128),
                        FK_BlogPostID = c.Int(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPost", t => t.FK_BlogPostID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.FK_UserId)
                .Index(t => t.FK_UserId)
                .Index(t => t.FK_BlogPostID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Like",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FK_UserId = c.String(maxLength: 128),
                        FK_BlogPostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPost", t => t.FK_BlogPostID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.FK_UserId)
                .Index(t => t.FK_UserId, unique: true)
                .Index(t => t.FK_BlogPostID, unique: true);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .Index(t => t.UserId)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.ProductItem",
                c => new
                    {
                        ProductItemID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                        ImageAlt = c.String(),
                        Title = c.String(),
                        ProductLine_ProductLineID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductItemID)
                .ForeignKey("dbo.ProductLine", t => t.ProductLine_ProductLineID)
                .Index(t => t.ProductLine_ProductLineID);
            
            CreateTable(
                "dbo.ProductLine",
                c => new
                    {
                        ProductLineID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProductLineID);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserViewModel",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.ProductItem", "ProductLine_ProductLineID", "dbo.ProductLine");
            DropForeignKey("dbo.BlogPost", "FK_UserId", "dbo.User");
            DropForeignKey("dbo.Comment", "FK_UserId", "dbo.User");
            DropForeignKey("dbo.IdentityUserRole", "UserId", "dbo.User");
            DropForeignKey("dbo.IdentityUserLogin", "User_Id", "dbo.User");
            DropForeignKey("dbo.Like", "FK_UserId", "dbo.User");
            DropForeignKey("dbo.Like", "FK_BlogPostID", "dbo.BlogPost");
            DropForeignKey("dbo.IdentityUserClaim", "UserId", "dbo.User");
            DropForeignKey("dbo.Comment", "FK_BlogPostID", "dbo.BlogPost");
            DropIndex("dbo.ProductItem", new[] { "ProductLine_ProductLineID" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "UserId" });
            DropIndex("dbo.IdentityUserLogin", new[] { "User_Id" });
            DropIndex("dbo.Like", new[] { "FK_BlogPostID" });
            DropIndex("dbo.Like", new[] { "FK_UserId" });
            DropIndex("dbo.IdentityUserClaim", new[] { "UserId" });
            DropIndex("dbo.Comment", new[] { "FK_BlogPostID" });
            DropIndex("dbo.Comment", new[] { "FK_UserId" });
            DropIndex("dbo.BlogPost", new[] { "FK_UserId" });
            DropTable("dbo.UserViewModel");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.ProductLine");
            DropTable("dbo.ProductItem");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.Like");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.User");
            DropTable("dbo.Comment");
            DropTable("dbo.BlogPost");
        }
    }
}
