namespace SCApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "FirstMidName", c => c.String());
            AlterColumn("dbo.Student", "LastName", c => c.String());
            AlterColumn("dbo.Course", "Title", c => c.String());
        }
    }
}
