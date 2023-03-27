using System;
using System.Collections.Generic;

namespace Festivals.ReverseEngineered
{
    public partial class Kadavuls
    {
        public Kadavuls()
        {
            Temples = new HashSet<Temples>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Temples> Temples { get; set; }
    }
}
