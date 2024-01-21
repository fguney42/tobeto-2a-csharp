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
            bool isCarYoung = now.Year - modelYear <= 20;

            if (!isCarYoung)
            {
                throw new BusinessException("The car is not younger than 20 years.");
            }
        }
    }
}