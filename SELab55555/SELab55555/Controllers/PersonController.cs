using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SELab55555.Models;
using Microsoft.AspNet.Identity;

namespace SELab55555.Controllers
{
    public class PersonController : Controller
    {
        PhoneBookDbEntities _db;
        public PersonController()
            //uygtyftrdfrdruutdrtr
        {
            _db = new PhoneBookDbEntities();
        }
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Authorize]
        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person per)
        {
            string str = User.Identity.GetUserId();
            //try
            //{
                // TODO: Add insert logic here
                Person p = new Person();
                p.FirstName = per.FirstName;
                p.MiddleName = per.MiddleName;
                p.LastName = per.LastName;
                p.DateOfBirth = per.DateOfBirth;
                p.HomeAddress = per.HomeAddress;
                p.HomeCity = per.HomeCity;
                p.AddedBy = str;
                p.AddedOn = DateTime.Now;
                p.FaceBookAccountId = per.FaceBookAccountId;
                p.LinkedInId = per.LinkedInId;
              //  p.UpdateOn = per.UpdateOn;
                p.TwitterId = per.TwitterId;
                p.EmailId = per.EmailId;

                _db.People.Add(p);
                _db.SaveChanges();

                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
