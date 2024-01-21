using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract;
public interface IModelDal : IEntityRepository<Model, int>
{
    IList<Model> GetListByBrand(int brandId);
    IList<Model> GetListByFuel(int fuelId);
    IList<Model> GetListByTransmission(int transmissionId);
}