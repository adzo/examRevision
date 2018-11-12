namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        CodeDepartement = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Mail = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Telephone = c.Int(nullable: false),
                        DateDePriseDeFonction = c.DateTime(),
                        Grade = c.String(),
                        Salaire = c.Int(),
                        DateEntree = c.DateTime(),
                        Niveau = c.Int(),
                        Payement = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Departement_CodeDepartement = c.Int(),
                    })
                .PrimaryKey(t => t.CodeDepartement)
                .ForeignKey("dbo.Departements", t => t.Departement_CodeDepartement)
                .Index(t => t.Departement_CodeDepartement);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        CodeDepartement = c.Int(nullable: false, identity: true),
                        NomDepartement = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodeDepartement);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        Code = c.Int(nullable: false),
                        NoteMatiere = c.Int(nullable: false),
                        Observation = c.String(),
                    })
                .PrimaryKey(t => new { t.NoteId, t.Code })
                .ForeignKey("dbo.Matieres", t => t.Code, cascadeDelete: true)
                .ForeignKey("dbo.Personnes", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.Code);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Code = c.Int(nullable: false, identity: true),
                        Duree = c.Int(nullable: false),
                        Libelle = c.String(),
                        Salle = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "Id", "dbo.Personnes");
            DropForeignKey("dbo.Notes", "Code", "dbo.Matieres");
            DropForeignKey("dbo.Personnes", "Departement_CodeDepartement", "dbo.Departements");
            DropIndex("dbo.Notes", new[] { "Code" });
            DropIndex("dbo.Notes", new[] { "Id" });
            DropIndex("dbo.Personnes", new[] { "Departement_CodeDepartement" });
            DropTable("dbo.Matieres");
            DropTable("dbo.Notes");
            DropTable("dbo.Departements");
            DropTable("dbo.Personnes");
        }
    }
}
