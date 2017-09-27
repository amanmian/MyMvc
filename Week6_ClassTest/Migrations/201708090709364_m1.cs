namespace Week6_ClassTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Wed.NoviceDetails",
                c => new
                    {
                        NoviceId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        CurrentAddress = c.String(),
                        Stream = c.String(),
                        FathersName = c.String(),
                        PermanentAddress = c.String(),
                    })
                .PrimaryKey(t => t.NoviceId)
                .ForeignKey("Wed.Novices", t => t.NoviceId)
                .Index(t => t.NoviceId);
            
            CreateTable(
                "Wed.Novices",
                c => new
                    {
                        NoviceId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Age = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.NoviceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Wed.NoviceDetails", "NoviceId", "Wed.Novices");
            DropIndex("Wed.NoviceDetails", new[] { "NoviceId" });
            DropTable("Wed.Novices");
            DropTable("Wed.NoviceDetails");
        }
    }
}
