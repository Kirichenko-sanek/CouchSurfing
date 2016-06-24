using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class Dialog : BaseEntity
    {
        public long IdUser { get; set; }
        public long IdCompanion { get; set; }

        public virtual User User { get; set; }
        public virtual User Companion { get; set; }
        public virtual List<Massage> Massages { get; set; }

        public Dialog()
        {
            Massages = new List<Massage>();
        }
    }
}
