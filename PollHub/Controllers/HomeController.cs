using PollHub.Models;
using PollHub.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace PollHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var ballots = new BallotViewModel
            {
                Ballots = _context.Ballots.ToList()
            };

            return View("BallotView", ballots);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}