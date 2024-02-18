using Intro.DataAccess.Abstrscts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //dependency injection
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //business rules
        //veri kaynağından çekilir...

       CourseDal courseDal = new CourseDal();
        return _courseDal.GetAll(); 

    }
}
