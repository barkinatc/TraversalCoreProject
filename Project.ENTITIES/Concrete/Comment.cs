using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Concrete
{
    public class Comment:BaseEntity
    {
        public string CommentUser { get; set; }
        public string CommentContent { get; set; }
        public int DestinationID { get; set; }

        //Relational prop

        public virtual  Destination Destination { get; set; }
    }
}
