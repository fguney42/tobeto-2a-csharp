using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.User;
using Business.Requests.User;
using Business.Responses.User;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Entities;
using Core.Utilities.Hashing;
using Core.Utilities.Security;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private ITokenHelper _tokenHelper;

        public UserManager(IUserDal userDal, ITokenHelper tokenHelper)
        {
            _userDal = userDal;
            _tokenHelper =  tokenHelper;
        }
        public AccessToken Login(LoginRequest request)
        {
            User? user = _userDal.Get(i => i.Email == request.Email);

            bool isPasswordCorrect = HashingHelper.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);
            if (!isPasswordCorrect)
            {
                throw new Exception("Şifre Yanlış");
            }
            return _tokenHelper.CreateToken(user); // using Core.Utilities.Security.JWT;
        }

        public void Register(RegisterRequest request)
        {
            byte[] passwordSalt, passwordHash;

            HashingHelper.CreatePasswordHash(request.Password,out passwordHash, out passwordSalt);

            User user = new User();

            user.Email = request.Email;
            user.Approved = false;
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            _userDal.Add(user);

        }
    }
}
