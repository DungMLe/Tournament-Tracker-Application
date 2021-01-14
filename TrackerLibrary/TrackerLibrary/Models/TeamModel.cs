using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Unique identifier for the Team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// A list of team member in team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represent team name
        /// </summary>
        public string TeamName { get; set; }

    }
}
