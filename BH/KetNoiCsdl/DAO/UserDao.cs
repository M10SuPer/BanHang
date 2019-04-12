using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using KetNoiCsdl.EF;
using PagedList;
using PagedList.Mvc;

namespace KetNoiCsdl.DAO
{
    public class UserDao
    {
        BanhangOnlineDbContext db = null;
        public UserDao()
        {
            db = new BanhangOnlineDbContext();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public bool Login(String UserName, string PassWord)
        {
            var res = db.Users.Count(x => x.UserName == UserName && x.Password == PassWord);
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public IEnumerable<User> ListAllPaging(int page, int pageSize)
        {
            return db.Users.OrderByDescending(x => x.CreatedDate).ToPagedList(page, pageSize);
        }
        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.Name = entity.Name;
                if (!string.IsNullOrEmpty(entity.Password))
                {
                    user.Password = entity.Password;
                }
                user.Name = entity.Name;
                user.Address = entity.Address;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch
          (Exception)
            {
                return false;
            }
        }
        public long Insert(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.IDPro;
        }
        //public Product GetByIDPro(string sanpham)
        //{
        //    return db.Products.SingleOrDefault(x => x.tensanpham == sanpham);
        //}
        public IEnumerable<Product> ListAllPaging1(int page, int pageSize)
        {
            return db.Products.OrderByDescending(x => x.IDPro).ToPagedList(page, pageSize);
        }
        public bool Update1(Product entity)
        {
            try
            {
                var pro = db.Products.Find(entity.IDPro);
                pro.tensanpham = entity.tensanpham;
                pro.gia = entity.gia;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Product ViewDetail1(int id)
        {
            return db.Products.Find(id);
        }
        public bool Delete1(int id)
        {
            try
            {
                var pro = db.Products.Find(id);
                db.Products.Remove(pro);
                db.SaveChanges();
                return true;
            }
            catch
          (Exception)
            {
                return false;
            }
        }


    }
}