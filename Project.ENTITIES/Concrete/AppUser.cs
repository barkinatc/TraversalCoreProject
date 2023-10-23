using Microsoft.AspNetCore.Identity;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Interface;
using System;
using System.Collections.Generic;

namespace Project.ENTITIES.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        //Relationa prop

        public List<Reservation> Reservations { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
