
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;


Console.WriteLine("Hello, World!");

string message = "Krediler";
int term = 12;
double amount = 10000.45;

bool isAuthenticated = true;

string name = "Furkan";

//veriables -->camelCase

// condition

if (isAuthenticated == true)
{
    Console.WriteLine($"Hoşgeldin {name}");
}
else
{
    Console.WriteLine("Giriş Yapınız");
}

string[] loans = {"kredi 1" , "kredi 2" , "kredi 3"};// db den gelecek.


for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();


for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


courseManager.GetAll();

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678";
customer1.FirstName = "Furkan";
customer1.LastName = "Utsal";
customer1.CustomerNumber = "1234567";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "4567890";
customer2.FirstName = "Mehmet";
customer2.LastName = "Utsal";
customer2.CustomerNumber = "4567890";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "7654345";
customer3.TaxNumber = "543234567";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "adad";
customer4.CustomerNumber = "7654778345";
customer4.TaxNumber = "54323456457";



BaseCustomer[] customers = {customer1,customer2,customer3,customer4};

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}






