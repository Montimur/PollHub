namespace PollHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBallotsAndTickets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ballots",
                c => new
                    {
                        BallotId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BallotId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        BallotId = c.Int(nullable: false, identity: true),
                        CandidateId = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 56),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.BallotId);
            
            AlterColumn("dbo.Votes", "VoterId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Votes", "CandidateId", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Votes", "CandidateId", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Votes", "VoterId", c => c.String(nullable: false, maxLength: 100));
            DropTable("dbo.Tickets");
            DropTable("dbo.Ballots");
        }
    }
}
