using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{
    public class PeopleRoot
    {
        public string Copyright { get; set; }
        public List<Person> People { get; set; }
    }
}
