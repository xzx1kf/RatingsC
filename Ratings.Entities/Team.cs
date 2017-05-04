using System.Collections.Generic;
using System.Text;

namespace Ratings.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
    } 

    public enum Result
    {
        Home = 0, Away = 1, Draw = 3
    }
}
