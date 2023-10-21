using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class MemberUserVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CreatedDate { get; set; }
        public string Status { get; set; }

    }
}
