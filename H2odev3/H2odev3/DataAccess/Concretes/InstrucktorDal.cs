using hafta2odev3.DataAccess.Abstracts;
using hafta2odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2odev3.DataAccess.Concretes
{
    public class InstrucktorDal: IInstrucktorDal
    {
        List<Instrucktor> ınstrucktors;
        public InstrucktorDal()
        {
            Instrucktor ınstrucktor = new Instrucktor();
            ınstrucktor.Name = "Engin Demiroğ";
            ınstrucktor.ID = 1;
            ınstrucktor.NationalIdentity = 123;

            Instrucktor ınstrucktor2 = new Instrucktor();
            ınstrucktor2.Name = "Salih ";
            ınstrucktor2.ID = 2;
            ınstrucktor2.NationalIdentity = 14;

            ınstrucktors = new List<Instrucktor> { ınstrucktor, ınstrucktor2 };

        }

        public List<Instrucktor> GetAll() 
        {
            return ınstrucktors;
        }

        public void Add(Instrucktor ınstrucktor)
        {
            ınstrucktors.Add(ınstrucktor);

        }

        public void Remove(Instrucktor ınstrucktor)
        {
            ınstrucktors.Remove(ınstrucktor);
        }
        public void Update(Instrucktor updatedInstrucktor)
        {
            // Güncellenecek öğeyi bul
            Instrucktor existingInstrucktor = ınstrucktors.FirstOrDefault(i => i.ID == updatedInstrucktor.ID);

            // Eğer öğe bulunursa güncelle
            if (existingInstrucktor != null)
            {
                existingInstrucktor.Name = updatedInstrucktor.Name;
                existingInstrucktor.NationalIdentity = updatedInstrucktor.NationalIdentity;
            }
            else
            {
                throw new ArgumentException("Güncellenecek öğe bulunamadı");
            }
        }


    }
}
