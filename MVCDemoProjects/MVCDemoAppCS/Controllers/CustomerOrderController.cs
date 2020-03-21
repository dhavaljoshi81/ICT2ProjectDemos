using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemoAppCS.Models;

namespace MVCDemoAppCS.Controllers
{
    public class CustomerOrderController : Controller
    {
        private BusinessDBEFContainer db = new BusinessDBEFContainer();

        // GET: CustomerOrder
        public ActionResult Index(int? Id = -1, string CustName = "")
        {

            if (Id != -1 && !CustName.Equals(""))  
            {
                var orders = db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails)
                    .Where(co => co.OrderId == Id)
                    .Where(co => co.Customer.CustomerName.Equals(CustName));

                return View(orders.ToList());
            }
            else if (!CustName.Equals(""))
            {
                var orders = db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails)
                    .Where(co => co.Customer.CustomerName.Equals(CustName));

                return View(orders.ToList());
            }
            else if (Id != -1)
            {
                var orders = db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails)
                    .Where(co => co.CustomerId == Id);

                return View(orders.ToList());
            }
            else
            {
                var orders = db.Orders.Include(o => o.Customer).Include(o => o.OrderDetails);
                return View(orders.ToList());
            }
        }

        // GET: CustomerOrder/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: CustomerOrder/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerName");
            return View();
        }

        // POST: CustomerOrder/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,OrderDate,CustomerId,TotalAmount")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerName", order.CustomerId);
            return View(order);
        }

        // GET: CustomerOrder/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerName", order.CustomerId);
            var custOrderDetail = db.OrderDetails.Where(cod => cod.OrderId == id);
            ViewBag.CustomerOrderDetail = custOrderDetail;
            return View(order);
        }

        // POST: CustomerOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,OrderDate,CustomerId,TotalAmount")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "CustomerId", "CustomerName", order.CustomerId);
            return View(order);
        }

        // GET: CustomerOrder/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: CustomerOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
