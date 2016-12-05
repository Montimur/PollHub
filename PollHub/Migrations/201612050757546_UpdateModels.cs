namespace PollHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tickets");
            DropPrimaryKey("dbo.Votes");
            AddColumn("dbo.Ballots", "Title", c => c.String(nullable: false, maxLength: 56));
            AlterColumn("dbo.Tickets", "BallotId", c => c.Int(nullable: false));
            AlterColumn("dbo.Votes", "BallotId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Tickets", "Title");
            AddPrimaryKey("dbo.Votes", "VoterId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Votes");
            DropPrimaryKey("dbo.Tickets");
            AlterColumn("dbo.Votes", "BallotId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Tickets", "BallotId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Ballots", "Title");
            AddPrimaryKey("dbo.Votes", "BallotId");
            AddPrimaryKey("dbo.Tickets", "BallotId");
        }
    }
}
