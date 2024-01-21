using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryModelDal : InMemoryEntityRepositoryBase<Model, int>, IModelDal
    {
        public IList<Model> GetListByBrand(int brandId)
        {
            IList<Model> modelsByBrand = _entities
                .Where(e => e.BrandId == brandId && e.DeletedAt == null)
                .ToList();

            return modelsByBrand;
        }

        public IList<Model> GetListByFuel(int fuelID)
        {
            IList<Model> modelsByFuel = _entities
                .Where(e => e.FuelId == fuelID && e.DeletedAt == null)
                .ToList();

            return modelsByFuel;
        }

        public IList<Model> GetListByTransmission(int transmissionID)
        {
            IList<Model> modelsByTransmission = _entities
                .Where(e => e.FuelId == transmissionID && e.DeletedAt == null)
                .ToList();

            return modelsByTransmission;
        }

        protected override int generateId()
        {
            int nextId = _entities.Count == 0
                ? 1
                : _entities.Max(e => e.Id) + 1;
            return nextId;
        }
    }
}