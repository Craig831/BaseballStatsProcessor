using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class RosterRoot
    {
        public string Copyright { get; set; }
        public List<Roster> Roster { get; set; }
        public string Link { get; set; }
        public int TeamId { get; set; }
        public string RosterType { get; set; }
    }
}
