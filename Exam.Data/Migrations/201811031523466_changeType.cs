namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personnes", "Type", c => c.Int());
            DropColumn("dbo.Personnes", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Personnes", "Type");
        }
    }
}
