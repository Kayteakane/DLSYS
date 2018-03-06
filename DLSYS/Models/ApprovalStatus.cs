using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLSYS.Models
{
    public class ApprovalStatus
    {
        public int id { get; set; }
        public string employee_id { get; set; }
        public string approver_id { get; set; }
        public string approval_date { get; set; }
        public string status { get; set; }
        public int week_num { get; set; }
    }
}