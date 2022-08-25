using DrugApi.Data;
using DrugApi.Models;

namespace DrugApi.Repos.cs
{
    public class ProductRepo 
    {
        private readonly DataContext _db;



        public ProductRepo(DataContext db)
        {
            _db = db;
        }

        public Products Create(Products products)
        {
            _db.products.Add(products);
            _db.SaveChanges();
            return products;
          
        }

        public void Delete(int id)
        {
            var products = _db.products.Find(id);
            _db.products.Remove(products);
            //return products;
           
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
