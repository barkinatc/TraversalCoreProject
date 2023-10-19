using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminCommentVM
    {
        public int ID { get; set; }
        public string CommentUser { get; set; }
        public string CommentContent { get; set; }
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
        public string CreatedDate { get; set; }

        public string  Status { get; set; }

    }
}
