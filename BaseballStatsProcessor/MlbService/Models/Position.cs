using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Position
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Abbreviation { get; set; }
    }
}
