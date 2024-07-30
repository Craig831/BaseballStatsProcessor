using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class TeamPitching
    {
        public int Runs { get; set; }
        public int HomeRuns { get; set; }
        public int StrikeOuts { get; set; }
        public int BaseOnBalls { get; set; }
        public int Hits { get; set; }
        public string Era { get; set; }
        public string InningsPitched { get; set; }
        public int EarnedRuns { get; set; }
        public int BattersFaced { get; set; }
        public int Outs { get; set; }
    }
}
