using Microsoft.AspNet.Identity;
using PollHub.Dtos;
using PollHub.Models;
using PollHub.ViewModels;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace PollHub.Controllers
{
    public class BallotController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public BallotController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Ballot(BallotDto dto)
        {
            var userId = User.Identity.GetUserId();
            var ballotId = dto.BallotId;

            return Ok();
        }

        public ActionResult RedirectToTickets()
        {
            return null;
        }
    }
}
