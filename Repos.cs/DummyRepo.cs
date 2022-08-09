using DrugApi.Data;
using DrugApi.Models;

namespace DrugApi.Repos.cs
{
    public class DummyRepo
    {
        private DataContext db;

        public DummyRepo(DataContext db)
        {
            this.db = db;
        }

        public Dummy Buy(Dummy b)
        {
            var a = (from i in db.products where i.ProductId == b.ProductId select i).SingleOrDefault();
            a.Stock -= 1;
            db.dummy.Add(b);
            db.SaveChanges();
            return b;
        }
    }
}
