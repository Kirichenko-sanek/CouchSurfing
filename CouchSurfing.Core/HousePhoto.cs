namespace CouchSurfing.Core
{
    public class HousePhoto : BaseEntity
    {
        public long IdHouse { get; set; }
        public long IdPhoto { get; set; }

        public virtual House House { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
