using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PollHub.Models;

namespace PollHub.ViewModels
{
    public class BallotViewModel
    {
        public IEnumerable<Ballot> Ballots { get; set; }
    }
}