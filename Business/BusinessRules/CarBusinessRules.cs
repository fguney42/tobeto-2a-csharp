using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using System.Globalization;

namespace Business.BusinessRules
{
    public class CarBusinessRules
    {
        private readonly ICarDal _carDal;

        public CarBusinessRules(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void CheckIfModelYearYoungerThanTwenty(short modelYear)
        {
            DateTime now = DateTime.Now;
            bool isYearYoungerThanTwenty = now.Year - modelYear <= 20;

            if (!isYearYoungerThanTwenty)
            {
                throw new BusinessException("This car is over 20 years old");
            }
        }
    }
}