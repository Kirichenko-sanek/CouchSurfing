using System;
using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class Massage : BaseEntity
    {
        public long IdDialog { get; set; }
        public string TextMassage { get; set; }
        public DateTime Date { get; set; }
        
        public virtual Dialog Dialog { get; set; }
    }
}
