using DrugApi.Repos.cs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DrugApi.Data;
using DrugApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DrugApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
      //  private readonly DummyRepo obj;


        private DataContext db;

        public CartController(DataContext db)
        {
            this.db = db;
        }

        //public CartController()
        //{
        //    obj = new DummyRepo(new DataContext());
        //}
        [HttpGet]
        public ActionResult<List<OrderDetail>> Cart()
        {
            var o = db.OrderDetail.ToList();
            
           return o;
        }


        // [Route("[action]")]
        // [Route("[Id]")]
        // [ActionName("Add")]
        [HttpPost]
        public OrderDetail AddCart(OrderDetail orderDetail)
        {

            
            var p = (from i in db.OrderDetail where i.ProductId == orderDetail.ProductId && i.UserId ==orderDetail.UserId select i).SingleOrDefault();
            if (p == null)
            {
                db.OrderDetail.Add(orderDetail);
            }
            else
            {
                p.qty += orderDetail.qty;
            }


            db.SaveChanges();
            return p;

        }
    }
}
//
