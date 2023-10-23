namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminDestinationVM
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Capacity { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
        public string CreatedDate { get; set; }

    }
}
