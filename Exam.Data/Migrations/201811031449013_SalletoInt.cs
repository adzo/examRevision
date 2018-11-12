namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalletoInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matieres", "Salle", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matieres", "Salle", c => c.String());
        }
    }
}
