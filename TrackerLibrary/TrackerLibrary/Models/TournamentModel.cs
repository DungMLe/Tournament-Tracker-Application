using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Unique identifier for the Tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represent name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// A double number which represent entry fee to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of teams that entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// A list represent prizes for winning teams of the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represent a list of rounds of the tournament with each round contains a list 
        /// of matchups of teams
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        
    }
}
