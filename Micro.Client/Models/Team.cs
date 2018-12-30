using System;
using System.Collections.Generic;

namespace Micro.Client.Models
{
    public class Team
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public ICollection<Member> Members { get; set; }

        public override string ToString() => this.Name;
    }
}
