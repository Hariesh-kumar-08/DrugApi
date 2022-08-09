using DrugApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrugApi.Repos.cs
{
    public interface ILogin
    {
        public Users Logins(Users u);

        public Users Registers(Users u);

        public Admin AdminLogin(Admin u);

        public void Save();
    }
}
