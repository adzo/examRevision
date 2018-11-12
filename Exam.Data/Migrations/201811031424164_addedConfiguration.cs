namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personnes", "Departement_CodeDepartement", "dbo.Departements");
            DropForeignKey("dbo.Notes", "Id", "dbo.Personnes");
            DropIndex("dbo.Personnes", new[] { "Departement_CodeDepartement" });
            RenameColumn(table: "dbo.Personnes", name: "Departement_CodeDepartement", newName: "DepartementFk");
            DropPrimaryKey("dbo.Personnes");
            AlterColumn("dbo.Personnes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Personnes", "DepartementFk", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Personnes", "Id");
            CreateIndex("dbo.Personnes", "DepartementFk");
            AddForeignKey("dbo.Personnes", "DepartementFk", "dbo.Departements", "CodeDepartement", cascadeDelete: true);
            AddForeignKey("dbo.Notes", "Id", "dbo.Personnes", "Id", cascadeDelete: true);
            DropColumn("dbo.Personnes", "CodeDepartement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnes", "CodeDepartement", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Notes", "Id", "dbo.Personnes");
            DropForeignKey("dbo.Personnes", "DepartementFk", "dbo.Departements");
            DropIndex("dbo.Personnes", new[] { "DepartementFk" });
            DropPrimaryKey("dbo.Personnes");
            AlterColumn("dbo.Personnes", "DepartementFk", c => c.Int());
            AlterColumn("dbo.Personnes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Personnes", "CodeDepartement");
            RenameColumn(table: "dbo.Personnes", name: "DepartementFk", newName: "Departement_CodeDepartement");
            CreateIndex("dbo.Personnes", "Departement_CodeDepartement");
            AddForeignKey("dbo.Notes", "Id", "dbo.Personnes", "CodeDepartement", cascadeDelete: true);
            AddForeignKey("dbo.Personnes", "Departement_CodeDepartement", "dbo.Departements", "CodeDepartement");
        }
    }
}
