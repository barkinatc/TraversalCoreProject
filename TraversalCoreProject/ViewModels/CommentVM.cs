using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewModels
{
    public class CommentVM
    {
        public int ID { get; set; }

        public string CommentUser { get; set; }
        public string CommentContent { get; set; }
        public int DestinationID { get; set; }

        public string CommentReply { get; set; }

        public string CreatedDate { get; set; }
        public string ModifedDate { get; set; }
        
    }
}
