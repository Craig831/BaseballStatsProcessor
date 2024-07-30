using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballStatsProcessor.MlbService.Models
{

    public class InfoBlock
    {
        public string Title { get; set; }
        public List<FieldList> FieldList { get; set; }
    }
}
