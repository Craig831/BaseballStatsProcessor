using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Date
    {
        [JsonProperty("date")]
        public string CalendarDate { get; set; }
        public int TotalItems { get; set; }
        public int TotalEvents { get; set; }
        public int TotalGames { get; set; }
        public int TotalGamesInProgress { get; set; }
        public List<Game> Games { get; set; }
        public List<Event> Events { get; set; }
    }
}
