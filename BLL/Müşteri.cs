using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Müşteri : Kişi
    {
        public override int AddKullanici(Kişi k)
        {
            throw new NotImplementedException();
        }
        public int AddKullanici(Müşteri m)
        {

        }
        public override int DeleteKullanici(int id)
        {
            throw new NotImplementedException();
        }

        public override DataTable ListKullaici()
        {
            throw new NotImplementedException();
        }

        public override int UpdateKullanici(Kişi k)
        {
            throw new NotImplementedException();
        }
    }
}
