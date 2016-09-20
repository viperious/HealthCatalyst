namespace Interview_Project.Data.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Personid { get; set; }
        public virtual Person Person { get; set; }
    } 
}
