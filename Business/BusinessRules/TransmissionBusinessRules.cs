using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class TransmissionBusinessRules
    {
        private readonly ITransmissionDal _transmissionDal;
        public TransmissionBusinessRules(ITransmissionDal transmissionDal)
        {
            _transmissionDal = transmissionDal;
        }

        public void CheckIfTransmissionNameNotExists(string transmissionName)
        {
            bool isBrandExists = _transmissionDal.GetList().Any(p => p.Name == transmissionName);
            if (isBrandExists)
                throw new BusinessException("Brand already exists.");
        }
    }
}
