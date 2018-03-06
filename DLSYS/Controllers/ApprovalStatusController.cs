using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DLSYS.Models;


namespace DLSYS.Controllers
{
    public class ApprovalStatusController : ApiController
    {
        ApprovalStatus[] statuses = new ApprovalStatus[]{
                     new ApprovalStatus { id=1, employee_id = "2256606", approver_id = "1304145", approval_date = "08/02/2018",
                         week_num = 5, status = "APR"},
                     new ApprovalStatus {id=2, employee_id = "2256606", approver_id = "1304145", approval_date = "",
                         week_num = 6, status = "SAV" }
         };


        [HttpGet]
        //public IEnumerable<DirectHours> getAllTasks(int week_num, string emp_id)
        public IHttpActionResult getWeekStatus(int week_num, string emp_id)
        {
            for (int i = 0; i < statuses.Length; i++)
            {
                if (statuses[i].week_num == week_num)
                {
                    return Ok(statuses[i]);
                }
            }
            
            return Ok("");
        }
    }
}
