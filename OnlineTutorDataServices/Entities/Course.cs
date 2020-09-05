using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorDataServices.Entities
{
    public class Course: ICourse
    {
        public string CourseID { get; set; }

        public string CourseName { get; set; }

        public decimal CourseInHours { get; set; }

        public int NumberOfOfferings { get; set; }

        public int NumberOfSubscribers { get; set; }

        public Course(string _courseID,string _courseName)
        {

            if (string.IsNullOrEmpty(_courseName) ||
                string.IsNullOrEmpty(_courseID))
                throw new ArgumentException("CourseID and CourseName are mandatory");
            CourseID = _courseID;
            CourseName = _courseName;

        }

    }
}
