using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.User;
using Business.Requests;
using Business.Requests.User;
using Business.Responses.User;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, UserBusinessRules userBusinessRules, IMapper mapper)
        {
            _userDal = userDal;
            _userBusinessRules = userBusinessRules;
            _mapper = mapper;
        }

        public AddUserResponse Add(AddUserRequest request)
        {
            ValidationTool.Validate(new AddUserRequestValidator(), request);
            _userBusinessRules.CheckIfEmailIsUnique(request.Email);
            var userToAdd = _mapper.Map<User>(request);
            User addedUser = _userDal.Add(userToAdd);
            var response = _mapper.Map<AddUserResponse>(addedUser);
            return response;
        }

        public DeleteUserResponse Delete(DeleteUserRequest request)
        {
            User userToDelete = _userDal.Get(predicate: user => user.Id == request.Id);
            _userBusinessRules.CheckIfUserExists(userToDelete.Id);
            User deletedUser = _userDal.Delete(userToDelete);
            var response = _mapper.Map<DeleteUserResponse>(deletedUser);
            return response;
        }


        public GetUserByIdResponse GetById(GetUserByIdRequest request)
        {
            User user = _userDal.Get(predicate: user => user.Id == request.Id);
            _userBusinessRules.CheckIfUserExists(user.Id);
            var response = _mapper.Map<GetUserByIdResponse>(user);
            return response;
        }

        public GetUserListResponse GetList(GetUserListRequest request)
        {
            IList<User> userList = _userDal.GetList().ToList();
            var response = _mapper.Map<GetUserListResponse>(userList);
            return response;
        }

        public UpdateUserResponse Update(UpdateUserRequest request)
        {
            User userToUpdate = _userDal.Get(predicate: user => user.Id == request.Id);
            _userBusinessRules.CheckIfUserExists(userToUpdate.Id);
            userToUpdate = _mapper.Map(request, userToUpdate);
            User updatedUser = _userDal.Update(userToUpdate!);
            var response = _mapper.Map<UpdateUserResponse>(updatedUser);
            return response;
        }
    }
}