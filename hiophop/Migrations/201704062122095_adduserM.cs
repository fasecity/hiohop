namespace hiophop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Proffession = c.String(nullable: false, maxLength: 100),
                        FavGenre = c.String(nullable: false, maxLength: 100),
                        FutureGenre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
        }
    }
}
