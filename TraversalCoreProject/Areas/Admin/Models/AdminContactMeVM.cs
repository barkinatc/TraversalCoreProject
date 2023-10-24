using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Admin.Models
{
    public class AdminContactMeVM
    {
        public string ID { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }

        public string MessageBody { get; set; }
    }
}
