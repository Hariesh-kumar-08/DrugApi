using DrugApi.Data;
using DrugApi.Models;
using DrugApi.Repos.cs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MethodsController : ControllerBase
    {
        //private DataContext db;

        //public MethodsController(DataContext db)
        //{
        //    this.db = db;
        //}



        private readonly  DummyRepo obj;

        public MethodsController()
        {
            obj = new DummyRepo(new DataContext());
        }
        [HttpPost]
        public Dummy Buy(Dummy b)
        {
            var c = obj.Buy(b);
            return c;
        }

    //    [HttpGet]
    //    public ActionResult<List<OrderDetail>> Cart()
    //    {
    //       return obj.Index();
    //    }

    //    [HttpPost]
    //    [Route("[action]")]
    //    //[Route("[Id]")]
    //    //  [ActionName("Add")]
    //    public ActionResult Add(OrderDetail orderDetail)
    //    {
    //        var  p = (from i in db.products where i.ProductId == orderDetail.ProductId select i).SingleOrDefault();
    //        obj.orderDetail(orderDetail);
    //        obj.Save();
    //       return Ok(p);
    //    }
    }
}

//'[[' or ']]'
