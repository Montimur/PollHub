using System.ComponentModel.DataAnnotations;

namespace PollHub.Models
{
    public class Vote
    {
        [Key]
        public int BallotId { get; set; }

        [Required]
        [StringLength(128)]
        public string VoterId { get; set; }

        [Required]
        [StringLength(128)]
        public string CandidateId { get; set; }
    }
}