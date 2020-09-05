using OnlineTutorDataServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorDataServices
{
    public class OnlineTutorRepository : IOnlineTutorRepository
    {
        public List<ICourse> AvailableCourses { get; set; }

        
        public OnlineTutorRepository()
        {
            if(AvailableCourses.Count == 0)
            {
                AvailableCourses =(List< ICourse>)CourseInitializer.SetCourses();
            }
        }

        public bool CreateCourse(ICourse course)
        {
            try
            {
                AvailableCourses.Add(course);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<ICourse> GetAllCourse()
        {
            return AvailableCourses;
        }
    }
}
