using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratings.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Computes_AttackStrength_For_One_Match()
        {
            var data = BuildTeamAndMatches(homeGoals: 1);

            var rater = new TeamRater(data);
            var result = rater.ComputeAttackStrength(19);

            Assert.AreEqual(1, result.AttackStrength);
        }

        [Test]
        public void Computes_AttackStrength_For_Two_Matches()
        {
            var data = BuildTeamAndMatches(homeGoals: new[] { 1, 3 });

            var rater = new TeamRater(data);
            var result = rater.ComputeAttackStrength(19);

            Assert.AreEqual(2, result.AttackStrength);
        }

        [Test]
        public void Computes_AttackStrength_For_First_N_Matches()
        {
            var data = BuildTeamAndMatches(homeGoals: new[] { 1, 3, 4, 4, 4 });

            var rater = new TeamRater(data);
            var result = rater.ComputeAttackStrength(2);

            Assert.AreEqual(2, result.AttackStrength);
        }

        private Team BuildTeamAndMatches(params int[] homeGoals)
        {
            var team = new Team();

            team.Matches =
                homeGoals.Select(r => new Match { HomeGoals = r, AwayGoals = 0 })
                         .ToList();

            return team;
        }
    }
}
