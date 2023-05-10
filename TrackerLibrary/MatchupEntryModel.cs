using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represent one team in the matchup
        /// </summary>
        /// <value></value>
        public TeamModel Teamcompeting { get; set; }
        /// <summary>
        /// Represent the score for this particular team
        /// </summary>
        /// <value></value>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came from as a winner.
        /// </summary>
        /// <value></value>
        public MatchupModel ParentMatchup { get; set; }
        
    }
}