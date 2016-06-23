namespace CouchSurfing.Core
{
    public class HouseStatus : BaseEntity
    {
        public long IdHouse { get; set; }
        public long IdStatus { get; set; }

        public virtual House House { get; set; }
        public virtual Status Status { get; set; }
    }
}
