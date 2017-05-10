namespace hiophop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameGenreToAppUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "Proffession", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "FavGenre", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.AspNetUsers", "FutureGenre", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FutureGenre");
            DropColumn("dbo.AspNetUsers", "FavGenre");
            DropColumn("dbo.AspNetUsers", "Proffession");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
