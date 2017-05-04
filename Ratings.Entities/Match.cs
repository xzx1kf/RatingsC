using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ratings.Entities
{
    public class Match
    {
        public int MatchId { get; set; }
        public DateTime MatchDate { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        [ForeignKey("HomeTeamId")]
        public Team HomeTeam { get; set; }

        [ForeignKey("AwayTeamId")]
        public Team AwayTeam { get; set; }

        public Result Result { get; set; }
    }
}
