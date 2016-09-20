namespace Interview_Project.Data.DTO
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string AddressType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int PersonId { get; set; }
    }
}