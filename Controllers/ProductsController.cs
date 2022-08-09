using Microsoft.AspNetCore.Http;
using DrugApi.Models;
using Microsoft.AspNetCore.Mvc;
using DrugApi.Repos.cs;
using DrugApi.Data;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProducts obj1;

        public ProductsController(IProducts obj)
        {
            obj1 = new ProductRepo(new DataContext());
        }


        [HttpGet]

        public ActionResult<List<Products>> Index()
        {

            return obj1.Get();

        }

        [HttpPost]

        public IActionResult Create(Products p)
        {
            obj1.Create(p);
            obj1.Save();
            var products = from i in obj1.Get() select i;
            return Ok(products);

        }

        [HttpGet("{id}")]

        public Products Details(int id)
        {
            var result = obj1.Details(id);
            return result;
        }

        [HttpPut("{id}")]

        public Products Edit(Products p)
        {
            var e = obj1.Update(p);
            obj1.Save();
            return e;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete( int id)
        {
            obj1.Delete(id);
            obj1.Save();
            var products = from i in obj1.Get() select i;
            return Ok(products);
        }















    }
}
