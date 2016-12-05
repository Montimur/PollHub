using System.ComponentModel.DataAnnotations;

namespace PollHub.Models
{
    public class Ticket
    {
        [Key]
        public int BallotId { get; set; }

        [Required]
        [StringLength(128)]
        public string CandidateId { get; set; }

        [Required]
        [StringLength(56)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}