using DrugApi.Data;
using DrugApi.Models;
using DrugApi.Repos.cs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //   private readonly IHttpContextAccessor _contextAccessor;

        private ILogin obj;

        public LoginController()
        {
            obj = new Login(new DataContext());
        }

        
        [HttpPost]
        public Users Login(Users users)
        {
           var result= obj.Logins(users);
            obj.Save();
            return result;

        }

        //[HttpPost]
        //public void Register(Users u)
        //{
        //    obj.Registers(u);


        //}
        [Route("AdminLogin")]
        [HttpPost]
        public Admin AdminLogin(Admin a)
        {
            var result = obj.AdminLogin(a);
            obj.Save();
            return result;

        }
    }  
}
