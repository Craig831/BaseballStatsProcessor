using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class GameStatus
    {
        public string AbstractGameState { get; set; }
        public string CodedGameState { get; set; }
        public string DetailedState { get; set; }
        public string StatusCode { get; set; }
        public string AbstractGameCode { get; set; }
        public string Reason { get; set; }
    }
}
