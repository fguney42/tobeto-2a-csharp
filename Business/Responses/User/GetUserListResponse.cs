using Business.Dtos.User;
using System.Collections.Generic;

namespace Business.Responses.User
{
    public class GetUserListResponse
    {
        public ICollection<UserListItemDto> Items { get; set; }
    }
}
