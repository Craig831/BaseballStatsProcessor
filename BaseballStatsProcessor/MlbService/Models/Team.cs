using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public Venue Venue { get; set; }
        public string TeamCode { get; set; }
        public string FileCode { get; set; }
        public string Abbreviation { get; set; }
        public string TeamName { get; set; }
        public string LocationName { get; set; }
        public string FirstYearOfPlay { get; set; }
        public League League { get; set; }
        public Division Division { get; set; }
        public Sport Sport { get; set; }
        public string ShortName { get; set; }
        public Record Record { get; set; }
        public Springleague SpringLeague { get; set; }
        public bool Active { get; set; }
    }
}
