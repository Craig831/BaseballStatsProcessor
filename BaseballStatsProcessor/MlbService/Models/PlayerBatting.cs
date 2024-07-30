using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class PlayerBatting
    {
        public string Note { get; set; }
        public int FlyOuts { get; set; }
        public int Runs { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int StrikeOuts { get; set; }
        public int BaseOnBalls { get; set; }
        public int Hits { get; set; }
        public int HitByPitch { get; set; }
        public int Rbi { get; set; }
        public int CaughtStealing { get; set; }
        public int StolenBases { get; set; }
        public int AtBats { get; set; }
        public int LeftOnBase { get; set; }
        public int SacBunts { get; set; }
        public int SacFlies { get; set; }
    }
}
