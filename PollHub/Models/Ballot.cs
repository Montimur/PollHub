using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PollHub.Models
{
    public class Ballot
    {
        [Key]
        public int BallotId { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }



        public Ballot()
        {
            var context = new ApplicationDbContext();

            Tickets = context.Tickets.ToList().Where(t => t.BallotId == BallotId);
        }
    }
}