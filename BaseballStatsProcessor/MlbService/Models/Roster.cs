using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Roster
    {
        public Person Person { get; set; }
        public string JerseyNumber { get; set; }
        public Position Position { get; set; }
        public PlayerStatus Status { get; set; }
        public int ParentTeamId { get; set; }
    }
}
