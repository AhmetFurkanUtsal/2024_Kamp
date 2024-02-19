using hafta2odev3.DataAccess.Abstracts;
using hafta2odev3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2odev3.Business
{
    public class InstrucktorManager

    {
        IInstrucktorDal _ınstrucktorDal;

        public InstrucktorManager(IInstrucktorDal ınstrucktorDal)
        {
            _ınstrucktorDal = ınstrucktorDal;
        }

        public List<Instrucktor> GetAll()
        {
            return _ınstrucktorDal.GetAll();
        }


    }
}
