using Intro.DataAccess.Abstrscts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CourseDal:ICourseDal // Data access layer
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".net 8 ";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 1;
            course2.Name = "Java";
            course2.Description = "Java 17 ";
            course2.Price = 0;

            courses = new List<Course> { course1, course2,};
        }

       
        public List<Course> GetAll()
        {
            // burada db işlemleri yapılır.
            return courses;
        }
        public void Add (Course course)
        {
            courses.Add(course);
        }

      
    }

    
}
