using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class LeagueRecord
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string Pct { get; set; }
    }
}
