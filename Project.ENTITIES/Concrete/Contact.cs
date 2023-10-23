namespace Project.ENTITIES.Concrete
{
    public class Contact : BaseEntity
    {
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
    }
}
