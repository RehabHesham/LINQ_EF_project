namespace Bills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "company_id", "dbo.Companies");
            DropIndex("dbo.Items", new[] { "company_id" });
            CreateTable(
                "dbo.Type_p",
                c => new
                    {
                        typ_id = c.Int(nullable: false, identity: true),
                        typ_name = c.String(nullable: false, maxLength: 150),
                        typ_notes = c.String(maxLength: 500),
                        company_id = c.Int(),
                    })
                .PrimaryKey(t => t.typ_id)
                .ForeignKey("dbo.Companies", t => t.company_id)
                .Index(t => t.typ_name, unique: true)
                .Index(t => t.company_id);
            
            AddColumn("dbo.Items", "type_id", c => c.Int());
            AlterColumn("dbo.Items", "company_id", c => c.Int());
            CreateIndex("dbo.Items", "company_id");
            CreateIndex("dbo.Items", "type_id");
            AddForeignKey("dbo.Items", "type_id", "dbo.Type_p", "typ_id");
            AddForeignKey("dbo.Items", "company_id", "dbo.Companies", "compan_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "company_id", "dbo.Companies");
            DropForeignKey("dbo.Items", "type_id", "dbo.Type_p");
            DropForeignKey("dbo.Type_p", "company_id", "dbo.Companies");
            DropIndex("dbo.Type_p", new[] { "company_id" });
            DropIndex("dbo.Type_p", new[] { "typ_name" });
            DropIndex("dbo.Items", new[] { "type_id" });
            DropIndex("dbo.Items", new[] { "company_id" });
            AlterColumn("dbo.Items", "company_id", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "type_id");
            DropTable("dbo.Type_p");
            CreateIndex("dbo.Items", "company_id");
            AddForeignKey("dbo.Items", "company_id", "dbo.Companies", "compan_id", cascadeDelete: true);
        }
    }
}
