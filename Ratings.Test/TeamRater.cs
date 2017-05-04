using System;
using System.Linq;

namespace Ratings.Test
{
    internal class TeamRater
    {
        private Team _team;

        public TeamRater(Team team)
        {
            this._team = team;
        }

        public RatingResult ComputeAttackStrength(int numberOfMatches)
        {
            var result = new RatingResult();

            var filterdMatches = _team.Matches.Take(numberOfMatches);
            var homeGoals = (int)filterdMatches.Sum(m => m.HomeGoals);

            result.AttackStrength = homeGoals / filterdMatches.Count();

            return result;
        }
    }
}