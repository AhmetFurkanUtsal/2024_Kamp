// See https://aka.ms/new-console-template for more information
using hafta2odev3.Business;
using hafta2odev3.DataAccess.Concretes;
using hafta2odev3.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new (new CourseDal());
List<Course> course = courseManager.GetAll(); // kurs dizisini çağırır  //1.50

foreach (var courses in course)
{
    Console.WriteLine("Kurslar: " + courses.Name + "**** İçerik: "+ courses.Description);
}

Console.WriteLine("Kurslar Listelendi");


InstrucktorManager ınstrucktorManager = new (new InstrucktorDal());
List<Instrucktor> ınstrucktors = ınstrucktorManager.GetAll();

foreach (var ınstrucktor in ınstrucktors)
{
    Console.WriteLine("Eğitmenler: " + ınstrucktor.Name + "/ Eğitmen Numarası " + ınstrucktor.ID);
}



//class BaseCourse
//{
//    public string Name { get; set; }

//    public string ID { get; set; }
//}
//class Course:BaseCourse
//{
//    public string Description { get; set; }

//    public int Price { get; set; }
//}

//class Category:BaseCourse
//{

//}

//class Instructor:BaseCourse
//{
//    public int NationalIdentity { get; set; }
//}




