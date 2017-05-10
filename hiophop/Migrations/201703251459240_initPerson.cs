namespace hiophop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        taste = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonModels");
        }
    }
}
