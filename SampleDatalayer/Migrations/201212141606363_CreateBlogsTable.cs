namespace SampleDatalayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBlogsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable("BLOGS", (t) => new
                {
                    ID = t.Int(false, true),
                    Title = t.String(false)
                }).PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
            DropTable("BLOGS");
        }
    }
}
