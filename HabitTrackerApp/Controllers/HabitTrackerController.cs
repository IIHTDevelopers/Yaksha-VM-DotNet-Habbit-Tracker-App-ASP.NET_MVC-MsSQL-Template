using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.DAL.Repository;
using HabitTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HabitTrackerApp.Controllers
{
    public class HabitTrackerController : Controller
    {
        private readonly IHabitTrackerInterface _Repository;
        public HabitTrackerController(IHabitTrackerInterface service)
        {
            _Repository = service;
        }
        public HabitTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: HabitTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Habit Habit)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Habit Habit)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}