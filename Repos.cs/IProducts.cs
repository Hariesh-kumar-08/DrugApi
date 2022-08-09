using DrugApi.Models;

namespace DrugApi.Repos.cs
{
    public interface IProducts
    {
        public List<Products> Get();
        public Products Details(int id);

        public void Create(Products products);

        public Products Update(Products products);

        public void Delete(int id);

        public void Save();
    }
}
