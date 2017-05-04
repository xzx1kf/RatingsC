using System.Collections.Generic;

namespace Ratings.Test
{
    internal class Team
    {
        public Team()
        {
        }

        public IList<Match> Matches { get; internal set; }
    }
}