namespace Proactiv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TopicsModels",
                c => new
                    {
                        TopicID = c.Int(nullable: false, identity: true),
                        TopicTitle = c.String(),
                        TopicDescription = c.String(),
                        TopicTag = c.String(),
                    })
                .PrimaryKey(t => t.TopicID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TopicsModels");
        }
    }
}
