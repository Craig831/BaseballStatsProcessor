using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Record
    {
        public int GamesPlayed { get; set; }
        public string WildCardGamesBack { get; set; }
        public string LeagueGamesBack { get; set; }
        public string SpringLeagueGamesBack { get; set; }
        public string SportGamesBack { get; set; }
        public string DivisionGamesBack { get; set; }
        public string ConferenceGamesBack { get; set; }
        public LeagueRecord LeagueRecord { get; set; }
        public Records Records { get; set; }
        public bool DivisionLeader { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}
