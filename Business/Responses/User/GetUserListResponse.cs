using Business.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.User
{
    public class GetUserListResponse
    {
        public ICollection<UserListItemDto> Items { get; set; }
    }
}
