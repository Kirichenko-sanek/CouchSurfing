using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class Status : BaseEntity
    {
        public string NameStatus { get; set; }

        public virtual List<HouseStatus> HouseStatuses { get; set; }

        public Status()
        {
            HouseStatuses = new List<HouseStatus>();
        }
    }
}
