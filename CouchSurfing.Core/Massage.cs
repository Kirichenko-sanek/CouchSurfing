using System;
using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class Massage : BaseEntity
    {
        public string TextMassage { get; set; }
        public DateTime Date { get; set; }       
    }
}
