namespace Week6_ClassTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("Wed.NoviceDetails", "Id");
        }
        
        public override void Down()
        {
            AddColumn("Wed.NoviceDetails", "Id", c => c.Int(nullable: false));
        }
    }
}
