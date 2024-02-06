
using Business.Concrete;
using Entities.Conrete;

Console.WriteLine("Hello");


//Degiskenler(out tutar, out kdv);

Console.WriteLine("");

SelamVer("furkan");
SelamVer("Ahmet");
SelamVer();
//Arrays

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

foreach (var ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };

string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" }; // string class interface referance tiplerdir

sehirler2 = sehirler1;
sehirler1[0] = "Çanakkale";
Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
// sayi2?? // int double bool.. değer tiplerdir.

List<string> yeniSehirler = new List<string> { "Afyon", "Sandıklı", "Çay" };
yeniSehirler.Add("Bucak");
foreach (var sehir in yeniSehirler)
{
    Console.WriteLine(sehir);
}

Person person1 = new Person();
person1.FirstName = " F";
person1.LastName = "U";
person1.DateOfBirthYear = 1990;
person1.NationalIdentity = 123;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


int sonuc = Topla(3,5);


static void SelamVer(string isim="isimsiz") // parametre
{
    Console.WriteLine("Merhaba " + isim);
}
 static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 +sayi2;
    Console.WriteLine("" +sonuc);
    return sonuc; //1.54dk
}

/*
Vatandas vatandas1 = new Vatandas();



static void Degiskenler(out double tutar, out double kdv)
{
    string mesaj = "Merhaba";
    tutar = 1000;
    kdv = 1.18;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Furkan";
    string soyad = "Utsal";
    int dogumYili = 1985;
    long tcNo = 1234567889;
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public int DogumYili { get; set; }

    public long TcNo { get; set; }
}
*/


