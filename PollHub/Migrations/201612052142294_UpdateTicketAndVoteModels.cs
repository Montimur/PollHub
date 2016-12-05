namespace PollHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTicketAndVoteModels : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tickets");
            AddColumn("dbo.Tickets", "TickedId", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Candidate", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Votes", "TicketId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "Title", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Tickets", new[] { "TickedId", "BallotId" });
            DropColumn("dbo.Tickets", "CandidateId");
            DropColumn("dbo.Votes", "CandidateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Votes", "CandidateId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Tickets", "CandidateId", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Tickets");
            AlterColumn("dbo.Tickets", "Title", c => c.String(nullable: false, maxLength: 56));
            DropColumn("dbo.Votes", "TicketId");
            DropColumn("dbo.Tickets", "Candidate");
            DropColumn("dbo.Tickets", "TickedId");
            AddPrimaryKey("dbo.Tickets", "Title");
        }
    }
}
