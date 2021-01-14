using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represent a list of matchup entry or teams
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represent the winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represent the round the matchup occurs
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
