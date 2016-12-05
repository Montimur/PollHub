using System.Web.Http;
using PollHub.Models;

namespace PollHub.Controllers
{
    public class TicketController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public TicketController()
        {
            _context = new ApplicationDbContext();
        }
    }
}
