using System;
using System.Collections.Generic;

namespace Festivals.ReverseEngineered
{
    public partial class TempleSannidhis
    {
        public int SannidhiId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int? TempleId { get; set; }

        public virtual Temples Temple { get; set; }
    }
}
