using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class Official
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Link { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
