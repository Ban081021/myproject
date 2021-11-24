using AssigmentManageStaff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssigmentManageStaff.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            var listStaff = new DBstaffContext().Staffs.ToList();
            return View(listStaff);
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(Staff model)
        {
            try
            {
                // TODO: Add insert logic here
                var Context = new DBstaffContext();
                Context.Staffs.Add(model);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
           
            var context = new DBstaffContext();
            var editting = context.Staffs.Find(id);
            return View(editting);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(Staff model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBstaffContext();
                var olditem = context.Staffs.Find(model.Id);
                olditem.Name = model.Name;
                olditem.Gender = model.Gender;
                olditem.Email = model.Email;
                olditem.phoneNumber = model.phoneNumber;
                olditem.IdPosition = model.IdPosition;
                olditem.isStaff = model.isStaff;
                olditem.isStaff = model.isStaff;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBstaffContext();
           var delete = context.Staffs.Find(id);
            return View(delete);
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBstaffContext();
                var delete = context.Staffs.Find(id);
                context.Staffs.Remove(delete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
