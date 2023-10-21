using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Concrete
{
   public class Destination:BaseEntity
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Capacity { get; set; }

        public string Description { get; set; }
        public string CoverImage { get; set; }

        public string Details1 { get; set; }
        public string Details2 { get; set; }

        public string Image2 { get; set; }

        //Relational prop

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public Destination()
        {
            Destination d = new Destination();
        }


    }
}
