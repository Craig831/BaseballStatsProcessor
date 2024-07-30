using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Player
    {
        //public string Name { get; set; }
        public Person Person { get; set; }
        public string JerseyNumber { get; set; }
        public Position Position { get; set; }
        public PlayerStats Stats { get; set; }
        public PlayerStatus Status { get; set; }
        public int ParentTeamId { get; set; }
        public string BattingOrder { get; set; }
        public PlayerStats SeasonStats { get; set; }
        public PlayerGameStatus GameStatus { get; set; }
        public List<Position> AllPositions { get; set; }
    }
}
