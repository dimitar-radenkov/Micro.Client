using System;

namespace Micro.Client.Models
{
    public class Member
    {
        public Guid ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString() =>
            $"{this.FirstName} {this.LastName}";
    }
}
