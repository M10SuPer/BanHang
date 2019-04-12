using KetNoiCsdl.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiCsdl.DAO
{
    class ContactDao
    {
        BanhangOnlineDbContext db = null;
        public ContactDao()
        {
            db = new BanhangOnlineDbContext();
        }
        public long Insert(Contact entity)
        {
            db.Contacts.Add(entity);
            db.SaveChanges();
            return entity.IDC;
        }
    }
}
