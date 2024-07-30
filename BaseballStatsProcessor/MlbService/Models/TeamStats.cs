using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class TeamStats
    {
        public TeamBatting Batting { get; set; }
        public TeamPitching Pitching { get; set; }
        public TeamFielding Fielding { get; set; }
    }
}
