using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class ModelBusinessRules
    {
        private readonly IModelDal _modelDal;
        public ModelBusinessRules(IModelDal modelDal)
        {

            _modelDal = modelDal;

        }

        public void CheckIfModelNameNotExists(string modelName)
        {
            bool isExists = _modelDal.GetList().Any(b => b.Name == modelName);
            if (isExists)
            {
                throw new BusinessException("Model already exists.");
            }
        }

        public void CheckIfModelNameLongerThanTwo(string modelName)
        {
            bool isValid = modelName.Length > 1;

            if (!isValid)
            {
                throw new BusinessException("Model name must be at least 2 characters.");
            }
        }

        public void CheckIfDailyPriceGreaterThanZero(decimal dailyPrice)
        {
            bool isValid = dailyPrice > 0;

            if (!isValid)
            {
                throw new BusinessException("Daily price must be greater than 0.");
            }
        }
    }
}