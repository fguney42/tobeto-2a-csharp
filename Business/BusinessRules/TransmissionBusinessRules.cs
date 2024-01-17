
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
                throw new Exception("Transmission already exists.");
            }
        }
        public void IsNullOrWhiteSpace(string transmissionName)
        {
            foreach (var transmissionDalString in _transmissionDal.GetList())
            {
                if (string.IsNullOrWhiteSpace(transmissionDalString.ToString()))
                {
                    throw new Exception("String is Null or string have whitespace character");
                }
            }
        }

    }

}
