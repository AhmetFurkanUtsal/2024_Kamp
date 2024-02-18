using Intro.DataAccess.Abstrscts;
using Intro.Entities;

public class EfCourseDal:ICourseDal // Data access layer
{
    List<Course> courses;
    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "Javascript";
        course1.Description = ".net 8 ";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "Java";
        course2.Description = "Java 17 ";
        course2.Price = 0;

        courses = new List<Course> { course1, course2, };
    }


    public List<Course> GetAll()
    {
        // burada db işlemleri yapılır.
        return courses;
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }


}