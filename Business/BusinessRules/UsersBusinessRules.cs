using Core.CrossCuttingConcerns.Exceptions;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class UsersBusinessRules
    {
        private readonly IUserDal _userDal;

        public UsersBusinessRules(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void CheckIfUserEmailExists(string email)
        {
            bool isExists = _userDal.GetList().Any(u => u.Email == email);
            if (isExists)
            {
                throw new Exception("User email already exists.");
            }
        }
     
        public User FindUserId(int id)
        {
            Core.Entities.User user = _userDal.GetList().SingleOrDefault(u => u.Id == id);
            return user;
        }

        public void CheckIfUserExists(User? users)
        {
            if (users is null)
                throw new NotFoundException("User not found.");
        }

       
    }
}
