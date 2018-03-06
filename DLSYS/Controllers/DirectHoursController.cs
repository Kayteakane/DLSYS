using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DLSYS.Models;

namespace DLSYS.Controllers
{
    public class DirectHoursController : ApiController
    {       
          DirectHours[] hours= new DirectHours[]{
                     new DirectHours { id=1, employee_id = "2256606", project = "TOPSTAR Development", variant = "SV", node = "B3REQ", task =
                         "#10987: The Offsets Implemented check to determine MW Fire Consent should be the same in all Tgt Acquis modes",
                         week_num = 10, mon = 8, tue = 8, wed = 6, thu = 8, fri = 10, sat = 1, sun = 1, remarks = ""},
                     new DirectHours {id=2, employee_id = "2256606", project = "TOPSTAR Development", variant = "BV", node = "B3REQ", task =
                         "#10987: Nothing Much",
                         week_num = 10, mon = 8, tue = 8, wed = 6, thu = 8, fri = 10, sat = 0, sun = 0, remarks = ""},
                     new DirectHours {id=3, employee_id = "2256606", project = "TOPSTAR Development", variant = "KV", node = "B3REQ", task =
                         "",
                         week_num = 10, mon = 2, tue = 4, wed = 6, thu = 8, fri = 10, sat = 1, sun = 1, remarks = "Nothing Much"}
         };

        [HttpGet]
        //public IEnumerable<DirectHours> getAllTasks(int week_num, string emp_id)
        public IHttpActionResult getAllDirectTasks(int week_num, string emp_id)
        {
            //return hours;
            return Ok(hours);
        }

        [HttpPost]
        public IHttpActionResult updateTask(int id)
        {
            /**var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);*/
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult getTask(int id)
        {
            /**var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);*/
            return Ok();
        }
    }
}
