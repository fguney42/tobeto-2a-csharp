using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITransmissionDal : IEntityRepository<Fuel, int>
    {
        // OPERATIONS // CRUD // CREATE READ UPDATE DELETE 
        void Add(Transmission transmissionToAdd);
    }
}