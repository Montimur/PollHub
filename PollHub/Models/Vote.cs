using System.ComponentModel.DataAnnotations;

namespace PollHub.Models
{
    public class Vote
    {
        [Key]
        [Required]
        [StringLength(128)]
        public string VoterId { get; set; }

        [Required]
        public int BallotId { get; set; }

        public int TicketId { get; set; }
    }
}