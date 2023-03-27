using System;
using System.Collections.Generic;

namespace Festivals.ReverseEngineered
{
    public partial class Temples
    {
        public Temples()
        {
            TempleSannidhis = new HashSet<TempleSannidhis>();
        }

        public int TempleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int? MolavarId { get; set; }

        public virtual Kadavuls Molavar { get; set; }
        public virtual ICollection<TempleSannidhis> TempleSannidhis { get; set; }
    }
}
