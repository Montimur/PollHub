using PollHub.Models;
using System.Collections.Generic;

namespace PollHub.ViewModels
{
    public class BallotViewModel
    {
        public IEnumerable<Ballot> Ballots { get; set; }
    }
}