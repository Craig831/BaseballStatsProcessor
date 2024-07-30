using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class PlayerPitching
    {
        public string Note { get; set; }
        public int Runs { get; set; }
        public int HomeRuns { get; set; }
        public int StrikeOuts { get; set; }
        public int BaseOnBalls { get; set; }
        public int Hits { get; set; }
        public string InningsPitched { get; set; }
        public int EarnedRuns { get; set; }
        public int BattersFaced { get; set; }
        public int Outs { get; set; }
        public int PitchesThrown { get; set; }
        public int Balls { get; set; }
        public int Strikes { get; set; }
    }
}
