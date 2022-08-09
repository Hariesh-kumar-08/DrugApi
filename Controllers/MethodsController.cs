using DrugApi.Data;
using DrugApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MethodsController : ControllerBase
    {

        private readonly DataContext _db;



        public MethodsController(DataContext db)
        {
            //
            _db = db;
        }
        [HttpPost]
        public IActionResult Buy(Dummy b)
        {
            var a = (from i in _db.products where i.ProductId == b.ProductId select i).SingleOrDefault();
            a.Stock-= 1;
            _db.dummy.Add(b);
            _db.SaveChanges();
            return Ok(b);

        }

    }
}
