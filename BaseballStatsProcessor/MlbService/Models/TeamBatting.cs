using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class TeamBatting
    {
        public int Runs { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int StrikeOuts { get; set; }
        public int BaseOnBalls { get; set; }
        public int Hits { get; set; }
        public string Avg { get; set; }
        public string Obp { get; set; }
        public string Slg { get; set; }
        public string Ops { get; set; }
        public int Rbi { get; set; }
        public int AtBats { get; set; }
        public int LeftOnBase { get; set; }
    }
}
