//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using XnetTest.Models;

//namespace XnetTest.Controllers
//{
//    public class CustomersController : Controller
//    {
//        private testsEntities db = new testsEntities();

//        // GET: Customers
//        public ActionResult Index()
//        {
//            var customers = db.Customers.Include(c => c.City).Include(c => c.City1);
//            return View(customers.ToList());
//        }

//        // GET: Customers/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Customer customer = db.Customers.Find(id);
//            if (customer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(customer);
//        }

//        // GET: Customers/Create
//        public ActionResult Create()
//        {
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description");
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description");
//            return View();
//        }

//        // POST: Customers/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "customerId,fullName,fullNameEng,dateBirth,identityCard,cityCode,bank,bankBranches,BankAccountNumber")] Customer customer)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Customers.Add(customer);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description", customer.cityCode);
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description", customer.cityCode);
//            return View(customer);
//        }

//        // GET: Customers/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Customer customer = db.Customers.Find(id);
//            if (customer == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description", customer.cityCode);
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description", customer.cityCode);
//            return View(customer);
//        }

//        // POST: Customers/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "customerId,fullName,fullNameEng,dateBirth,identityCard,cityCode,bank,bankBranches,BankAccountNumber")] Customer customer)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(customer).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description", customer.cityCode);
//            ViewBag.cityCode = new SelectList(db.Cities, "code", "description", customer.cityCode);
//            return View(customer);
//        }

//        // GET: Customers/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Customer customer = db.Customers.Find(id);
//            if (customer == null)
//            {
//                return HttpNotFound();
//            }
//            return View(customer);
//        }

//        // POST: Customers/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Customer customer = db.Customers.Find(id);
//            db.Customers.Remove(customer);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
