using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Team
    {
        public string Name { get; set; }
        public Dictionary<string, int> Worms { get; set; }
        public int TotalScore { get; set; }
        public int AverageScore { get; set; }
    }
}
