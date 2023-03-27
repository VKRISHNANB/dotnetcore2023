using System;
using System.Collections.Generic;

namespace Festivals.ReverseEngineered
{
    public partial class Festivals
    {
        public int FestivalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int NoOfDays { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? ReligionId { get; set; }

        public virtual Religions Religion { get; set; }
    }
}
