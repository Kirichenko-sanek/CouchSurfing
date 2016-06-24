using System;

namespace CouchSurfing.Core
{
    public class Application : BaseEntity
    {
        public long IdUser { get; set; }
        public long IdClient { get; set; }
        public long IdHouse { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual User Client { get; set; }
        public virtual House House { get; set; }
    }
}
