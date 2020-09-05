using OnlineTutorDataServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OnlineTutorDataServices
{
    public static class CourseInitializer
    {


        public static IList<ICourse> SetCourses()
        {
            JObject o = JObject.Parse("");

            JArray a = (JArray)o["d"];

            IList<ICourse> courses = a.ToObject<IList<ICourse>>();

            return courses;
        }



    }
}
