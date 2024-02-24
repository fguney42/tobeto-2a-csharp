using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class UserBusinessRules
    {
        private readonly IUserDal _userDal;

        public UserBusinessRules(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void CheckIfEmailIsUnique(string email)
        {
            bool isEmailUnique = _userDal.Get(user => user.Email == email) == null;
            if (!isEmailUnique)
                throw new BusinessException("Email is not unique.");
        }

        public void CheckIfUserExists(int userId)
        {
            User? user = _userDal.Get(u => u.Id == userId);
            if (user == null)
                throw new NotFoundException("User not found.");
        }
    }
}
