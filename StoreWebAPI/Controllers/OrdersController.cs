using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using StoreWebAPI.Models;

namespace StoreWebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        private StoreISIEntities2 db = new StoreISIEntities2();

        // GET: sklepAPI/Orders?token=&unpaid=
        [HttpGet]
        public async Task<IHttpActionResult> GetUnpaidOrders(string token, bool unpaid)
        {
            User user = db.Users.Where(c => c.APIToken == token).First();
            var orders =  db.Orders.Where(c => c.UserId == user.Id && c.Unpaid == unpaid).ToList();
            
            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        // GET: sklepAPI/Orders?token=&order_id=
        [HttpGet]
        public async Task<IHttpActionResult> GetOrderById(string token, int order_id)
        {
            User user = db.Users.Where(c => c.APIToken == token).First();
            Order order = db.Orders.Where(c => c.UserId == user.Id && c.Id == order_id).First(); 

            if (order == null)
            {
                return NotFound();
            }

            return Ok(new OrderE(order.Id, order.Amount, order.InvoiceNo, user.Email));
        }

        /*
        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public async Task<IHttpActionResult> PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
        }
        */

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.Id == id) > 0;
        }
    }
}