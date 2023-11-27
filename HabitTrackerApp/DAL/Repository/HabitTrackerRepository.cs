using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HabitTrackerApp.DAL.Repository
{
    public class HabitTrackerRepository : IHabitTrackerRepository
    {
        private HabitTrackerDbContext _context;
        public HabitTrackerRepository(HabitTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Habit> GetHabits()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Habit GetHabitByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Habit InsertHabit(Habit Habit)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteHabit(int HabitID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateHabit(Habit Habit)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
