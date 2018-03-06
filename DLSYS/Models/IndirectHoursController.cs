using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace DLSYS.Models
{
    public class IndirectHoursController : ApiController
    {
        IndirectHours[] hours = new IndirectHours[]
{
                    new IndirectHours { id=1, employee_id = "2256606", indirect_task = "Indirect Meeting", task = "Update Meeting for CR",
                        week_num = 10, mon = 8, tue = 8, wed = 6, thu = 8, fri = 10, sat = 0, sun = 0, remarks = "", status = "APR"},
                    new IndirectHours {id=2, employee_id = "2256606", indirect_task = "Sick Leave",  task = "",
                        week_num = 10, mon = 8, tue = 8, wed = 6, thu = 8, fri = 10, sat = 1, sun = 1, remarks = "", status = "APR" },

};

        [HttpGet]
        //public IEnumerable<DirectHours> getAllTasks(int week_num, string emp_id)
        public IHttpActionResult getAllIndirectTasks(int week_num, string emp_id)
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

        //new entry
        /**[HttpPost]
        public JsonResult InsertCustomer(Customer customer)
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                entities.Customers.Add(customer);
                entities.SaveChanges();
            }

            return Json(customer);
        }


        //update entry
        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                Customer updatedCustomer = (from c in entities.Customers
                                            where c.CustomerId == customer.CustomerId
                                            select c).FirstOrDefault();
                updatedCustomer.Name = customer.Name;
                updatedCustomer.Country = customer.Country;
                entities.SaveChanges();
            }

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult DeleteCustomer(int customerId)
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                Customer customer = (from c in entities.Customers
                                     where c.CustomerId == customerId
                                     select c).FirstOrDefault();
                entities.Customers.Remove(customer);
                entities.SaveChanges();
            }
            return new EmptyResult();
        }*/
    }
}
