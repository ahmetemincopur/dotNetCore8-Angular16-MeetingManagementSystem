using MeetingManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Application.Abstractions
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
