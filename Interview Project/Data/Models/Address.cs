namespace Interview_Project.Data.Models
{
    public class Address
    {
        public int Id { get; set; }
        public AddressTypes AddressType { get; set;}
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
