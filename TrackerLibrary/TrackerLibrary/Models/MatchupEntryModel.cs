using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
        
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifier for the matchup entry.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represent one team in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score for a particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represent the matchup that this team came from as the winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
