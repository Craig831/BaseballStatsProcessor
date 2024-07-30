using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class PlayerGameStatus
    {
        public bool IsCurrentBatter { get; set; }
        public bool IsCurrentPitcher { get; set; }
        public bool IsOnBench { get; set; }
        public bool IsSubstitute { get; set; }
    }
}
