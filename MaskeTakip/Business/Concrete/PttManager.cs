using Business.Abstract;
using Entities.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService // class ı çıplak bırakmadık
    {
        //pttmanager in bağımlı olduğu sınıf yerine onun interface ini yazdık.
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) // cONSTRUCTOR new yapıldığında çalışır.
        {
            _applicantService = applicantService; //diğer blokta applicationService e ulaşmak için
        }
        public void GiveMask(Person person) 
        {
           // PersonManager personManager = new PersonManager(); // vatandaşa bağımlı oldu, yabancılar??
            if(_applicantService.CheckPerson(person)) // vatandaş ise
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + "maske verilemedi");
            }
        }
    }
}
