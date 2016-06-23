using System;
using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class Photo : BaseEntity
    {
        public string Url { get; set; }
        public DateTime Date { get; set; }

        public virtual List<HousePhoto> HousePhotos { get; set; }

        public Photo()
        {
            HousePhotos = new List<HousePhoto>();
        }
    }
}
