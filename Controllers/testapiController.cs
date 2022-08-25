using DrugApi.Models;
using DrugApi.Repos.cs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testapiController : ControllerBase
    {
        private readonly ProductRepo _pizzaobj;
        public testapiController(ProductRepo pizzaobj)
        {
            _pizzaobj = pizzaobj;
        }
        [HttpPost]
        public ActionResult<Products> PostPurchase(Products purchase)
        {
            _pizzaobj.Create(purchase);
            return purchase;
        }
    }
}
