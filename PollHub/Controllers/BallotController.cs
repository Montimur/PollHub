using Microsoft.AspNet.Identity;
using PollHub.Dtos;
using PollHub.Models;
using System.Linq;
using System.Web.Http;

namespace PollHub.Controllers
{
    public class BallotController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public BallotController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Vote(VoteDto dto)
        {
            var userId = User.Identity.GetUserId();
            var ballotId = dto.BallotId;

            if (_context.Votes.Any(v => v.BallotId == ballotId && v.VoterId == userId))
                return BadRequest("You have already cast your vote on this ballot.");

            var vote = new Vote
            {
                VoterId = userId,
                CandidateId = dto.CandidateId,
                BallotId = dto.BallotId
            };

            _context.Votes.Add(vote);
            _context.SaveChanges();

            return Ok();
        }
    }
}
