﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class HomeAwayBase
    {
        public Team Team { get; set; }
        public TeamStats TeamStats { get; set; }
        public Players Players { get; set; }
        public List<int> Batters { get; set; }
        public List<int> Pitchers { get; set; }
        public List<int> Bench { get; set; }
        public List<int> Bullpen { get; set; }
        public List<int> BattingOrder { get; set; }
        public List<Info> Info { get; set; }
        public List<Note> Note { get; set; }
        public LeagueRecord LeagueRecord { get; set; }
        public int Score { get; set; }
        public bool IsWinner { get; set; }
        public bool SplitSquad { get; set; }
        public int SeriesNumber { get; set; }
    }
}
