using System;

namespace CouchSurfing.Core
{
    public class Comment : BaseEntity
    {
        public long IdUser { get; set; }
        public long IdHouse { get; set; }
        public string TextComment { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
        public virtual House House { get; set; }
    }
}
