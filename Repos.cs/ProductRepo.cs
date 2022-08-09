using DrugApi.Data;
using DrugApi.Models;

namespace DrugApi.Repos.cs
{
    public class ProductRepo : IProducts
    {
        private readonly DataContext _db;



        public ProductRepo(DataContext db)
        {
            _db = db;
        }

        public void Create(Products products)
        {
            _db.products.Add(products);
          
        }

        public void Delete(int id)
        {
            var products = _db.products.Find(id);
            _db.products.Remove(products);
           
        }

        public Products Details(int id)
        {
            var d=_db.products.Find(id);
            return d;
        }

        public List<Products> Get()
        {
            var p= _db?.products.ToList() ;
            return p ;
        }

        public Products Update(Products products)
        {
            //_db.products.Find(id);
           _db.products.Update(products);
            return products;
        }

        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
