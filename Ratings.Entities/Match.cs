using System;

namespace Ratings.Entities
{
    public class Match
    {
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }

        public int HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public Result Result { get; set; }
    }
}
