using OnlineTutorDataServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutorDataServices
{
    public interface IOnlineTutorRepository
    {
        List<ICourse> GetAllCourse();
        bool CreateCourse(ICourse course);

        //TODO if entity framework is used
        //bool SaveAll();
    }
}
