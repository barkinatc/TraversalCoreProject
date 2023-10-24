using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminAnnouncementVM
    {
        public int ID { get; set; }
        public string CreateDate { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
