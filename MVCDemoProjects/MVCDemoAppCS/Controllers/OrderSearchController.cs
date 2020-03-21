using MVCDemoAppCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoAppCS.Controllers
{
    public class OrderSearchController : Controller
    {
        private BusinessDBEFContainer db = new BusinessDBEFContainer();

        // GET: OrderSearch/Search
        public ActionResult Search()
        {
            return View();
        }

        // POST: OrderSearch/Search
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(OrderSearch orderSearch)
        {
            var orders = db.Orders.Where(o => o.CustomerId == orderSearch.CustomerId);

            ViewBag.Odr = orders;
            return View();// orders.ToList());
        }


        // GET: OrderSearch/Id
        public ActionResult SearchByOrder(int? Id)
        {
            return View();
        }


        // GET: OrderSearch/Id
        public ActionResult SearchByCustomer(int? Id)
        {
            return View();
        }

        // GET: OrderSearch/Id
        public ActionResult SearchByCustomer(string Name)
        {
            return View();
        }
    }
}