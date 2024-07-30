using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class PlayerStats
    {
        public PlayerBatting Batting { get; set; }
        public PlayerPitching Pitching { get; set; }
        public PlayerFielding Fielding { get; set; }
    }
}
