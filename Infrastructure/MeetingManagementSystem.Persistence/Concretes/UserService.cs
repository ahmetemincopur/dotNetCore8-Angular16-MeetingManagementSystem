using MeetingManagementSystem.Application.Abstractions;
using MeetingManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Persistence.Concretes
{
    public class UserService : IUserService
    {
        public List<Users> GetUsers()
        => new()
        {
            new(){Id=Guid.NewGuid(), Firstname="Ahmet", Lastname="Çöpür", Email="ahmetemincopur@outlook.com", Password="ahmet123", PhoneNumber="5389465401"},
            new(){Id=Guid.NewGuid(), Firstname="Emin", Lastname="Çöpür", Email="ahmetemincopur@outlook.com", Password="ahmet123", PhoneNumber="5389465401"},
            new(){Id=Guid.NewGuid(), Firstname="Mehmet", Lastname="Çöpür", Email="ahmetemincopur@outlook.com", Password="ahmet123", PhoneNumber="5389465401"},
            new(){Id=Guid.NewGuid(), Firstname="Ali", Lastname="Çöpür", Email="ahmetemincopur@outlook.com", Password="ahmet123", PhoneNumber="5389465401"},
            new(){Id=Guid.NewGuid(), Firstname="Umur", Lastname="Çöpür", Email="ahmetemincopur@outlook.com", Password="ahmet123", PhoneNumber="5389465401"}

        };
    }
}
