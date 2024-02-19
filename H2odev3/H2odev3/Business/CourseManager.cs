using hafta2odev3.DataAccess.Abstracts;
using hafta2odev3.DataAccess.Concretes;
using hafta2odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2odev3.Business
{
    public class CourseManager
    {
        IGenericDal _courseDal;

        public CourseManager(IGenericDal courseDal)
        {
            _courseDal = courseDal;
        }

        public CourseManager(CourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()  
        {
            

            //business rules
           // CourseDal courseDal = new CourseDal();
            return _courseDal.GetAll();
            
        }
    }



    
}
