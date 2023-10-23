using Project.ENTITIES.Enums;
using Project.ENTITIES.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project.ENTITIES.Concrete
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public BaseEntity()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;
        }


    }
}
