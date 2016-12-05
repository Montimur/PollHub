using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PollHub.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        [Column(Order = 1)]
        public int TickedId { get; set; }

        [Key]
        [Required]
        [Column(Order = 2)]
        public int BallotId { get; set; }

        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(128)]
        public string Candidate { get; set; }
    }
}