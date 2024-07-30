using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class BoxScoreRoot
    {
        public string Copyright { get; set; }
        public Teams Teams { get; set; }
        public List<Official> Officials { get; set; }
        public List<Info> Info { get; set; }
        public List<string> PitchingNotes { get; set; }
    }
}
