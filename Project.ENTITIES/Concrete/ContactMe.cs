namespace Project.ENTITIES.Concrete
{
    public class ContactMe : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }

        public string MessageBody { get; set; }

    }
}
