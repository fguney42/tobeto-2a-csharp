using Business.Requests.User;
using Business.Requests;
using Business.Responses.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        GetUserListResponse GetList(GetUserListRequest request);

        GetUserByIdResponse GetById(GetUserByIdRequest request);

        AddUserResponse Add(AddUserRequest request);

        UpdateUserResponse Update(UpdateUserRequest request);

        DeleteUserResponse Delete(DeleteUserRequest request);
    }
}
