using HabitTrackerApp.DAL.Interface;
using HabitTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HabitTrackerApp.DAL.Repository
{
    public class HabitTrackerService : IHabitTrackerInterface
    {
        private IHabitTrackerRepository _repo;
        public HabitTrackerService(IHabitTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteHabit(int HabitId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Habit GetHabitByID(int HabitId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Habit> IHabitTrackerInterface.GetHabits()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Habit IHabitTrackerInterface.InsertHabit(Habit Habit)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IHabitTrackerInterface.UpdateHabit(Habit Habit)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}