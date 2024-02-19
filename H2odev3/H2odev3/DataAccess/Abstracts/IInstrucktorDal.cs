using hafta2odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2odev3.DataAccess.Abstracts
{
    public interface IInstrucktorDal
    {
        List<Instrucktor> GetAll();
        void Add(Instrucktor ınstrucktor);

        void Remove(Instrucktor ınstrucktor);

        void Update(Instrucktor updatedInstrucktor);
    }
}
