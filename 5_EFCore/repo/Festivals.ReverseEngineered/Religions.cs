using System;
using System.Collections.Generic;

namespace Festivals.ReverseEngineered
{
    public partial class Religions
    {
        public Religions()
        {
            Festivals = new HashSet<Festivals>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Festivals> Festivals { get; set; }
    }
}
