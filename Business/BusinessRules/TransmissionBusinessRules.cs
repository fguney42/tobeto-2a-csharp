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
            bool isExists = _transmissionDal.GetList().Any(b => b.Name == transmissionName);
            if (isExists)
            {
                throw new BusinessException("Brand already exists.");
            }
        }
    }
}
