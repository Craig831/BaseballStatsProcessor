using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Game
    {
        public int GamePk { get; set; }
        public string Link { get; set; }
        public string GameType { get; set; }
        public string Season { get; set; }
        public DateTime GameDate { get; set; }
        public GameStatus Status { get; set; }
        public Teams Teams { get; set; }
        public Venue Venue { get; set; }
        public Content Content { get; set; }
        public bool IsTie { get; set; }
        public string DoubleHeader { get; set; }
        public string GamedayType { get; set; }
        public string Tiebreaker { get; set; }
        public int GameNumber { get; set; }
        public string CalendarEventID { get; set; }
        public string SeasonDisplay { get; set; }
        public string DayNight { get; set; }
        public string Description { get; set; }
        public int ScheduledInnings { get; set; }
        public int GamesInSeries { get; set; }
        public int SeriesGameNumber { get; set; }
        public string SeriesDescription { get; set; }
        public string RecordSource { get; set; }
        public string IfNecessary { get; set; }
        public string IfNecessaryDescription { get; set; }
        public DateTime RescheduleDate { get; set; }
        public DateTime RescheduledFrom { get; set; }
    }
}
