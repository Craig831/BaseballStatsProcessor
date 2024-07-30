using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class ScheduleRoot
    {
        public string Copyright { get; set; }
        public int TotalItems { get; set; }
        public int TotalEvents { get; set; }
        public int TotalGames { get; set; }
        public int TotalGamesInProgress { get; set; }
        public List<Date> Dates { get; set; }
    }
}
