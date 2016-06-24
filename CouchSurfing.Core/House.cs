using System.Collections.Generic;

namespace CouchSurfing.Core
{
    public class House : BaseEntity
    {
        public long IdUser { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberHouse { get; set; }
        public string Description { get; set; }
        
        public virtual User User { get; set; }

        public virtual List<HousePhoto> HousePhotos { get; set; }
        public virtual List<HouseStatus> HouseStatuses { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Application> Applications { get; set; }

        public House()
        {
            HousePhotos = new List<HousePhoto>();
            HouseStatuses = new List<HouseStatus>();
            Comments = new List<Comment>();
            Applications = new List<Application>();
        }
    }
}
