using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using DLSYS.Models;
using System.Web;

namespace DLSYS.Controllers
{
    public class CostCenterController : ApiController
    {
        /**CostCenter[] products = new CostCenter[]
{
            new CostCenter { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new CostCenter { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new CostCenter { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
};

        public IEnumerable<CostCenter> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }*/

        // GET: Home
        /**public IHttpActionResult Index()
        {
            CustomersEntities entities = new CustomersEntities();
            return View(entities.Customers);
        }

        /**[HttpPost]
        public JsonResult InsertCustomer(CostCenter cc)
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                entities.Customers.Add(cc);
                entities.SaveChanges();
            }

            return Json(cc);
        }

        [HttpPost]
        public IHttpActionResult UpdateCustomer(CostCenter cc)
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                CostCenter updatedCustomer = (from c in entities.Customers
                                            where c.CustomerId == customer.CustomerId
                                            select c).FirstOrDefault();
                updatedCustomer.Name = customer.Name;
                updatedCustomer.Country = customer.Country;
                entities.SaveChanges();
            }

            return new EmptyResult();
        }

        [HttpPost]
        public IHttpActionResult DeleteCustomer(int customerId)
        {
            using (CustomersEntities entities = new CustomersEntities())
            {
                CostCenter customer = (from c in entities.Customers
                                     where c.CustomerId == customerId
                                     select c).FirstOrDefault();
                entities.Customers.Remove(customer);
                entities.SaveChanges();
            }
            return new EmptyResult();
        }*/
    }
}
