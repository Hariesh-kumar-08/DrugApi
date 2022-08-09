using DrugApi.Data;
using DrugApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrugApi.Repos.cs
{
    public class Login : ILogin
    {

        private readonly DataContext _db;



        public Login(DataContext db)
        {
            _db = db;
        }
        public Users Logins(Users u)
        {
            if (u.UserId != 0)
            {
                var result = (from i in _db.users where i.Password == u.Password && i.UserId == u.UserId select i).SingleOrDefault();

                return result;
            }
            else
            {               
                _db.Add(u);
                return u;
            }
        }

        public Users Registers(Users u)
        {
            _db.Add(u);
            return u;

        }

        public Admin AdminLogin(Admin u)
        {
            if (u.AdminId != 0)
            {
                var result = (from i in _db.admins where i.password == u.password && i.AdminId == u.AdminId select i).SingleOrDefault();

                return result;
            }
            else
            {
                return null;
            }

        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
