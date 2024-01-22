using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;
internal class EfBrandDal : IBrandDal
{
    MyDbContext _dbContext;
    public void Add(Brand entity)
    {
       _dbContext.Add(entity);
    }

    public void Delete(Brand entity)
    {
        Brand deletedBrand = _dbContext.Brands.FirstOrDefault(p => p.Name == entity.Name);
        if (deletedBrand != null)
        {
            _dbContext.Remove(deletedBrand);
        }
    }

    public Brand? GetById(int id)
    {
        Brand getById = _dbContext.Brands.FirstOrDefault(p=>p.Id == id);
        return getById != null ? (getById) : null;
    }

    public IList<Brand> GetList()
    {
        return _dbContext.Brands.ToList();
    }

    public void Update(Brand entity)
    {
        Brand updatedBrand = _dbContext.Brands.FirstOrDefault(p=> p.Id == entity.Id);
        updatedBrand.Name = entity.Name;
    }
}
