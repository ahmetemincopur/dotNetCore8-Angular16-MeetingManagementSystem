using Microsoft.EntityFrameworkCore;
using MeetingManagementSystem.Application.Abstractions;
using MeetingManagementSystem.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingManagementSystem.Persistence.Contexts;

namespace MeetingManagementSystem.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserService>();
            services.AddDbContext<MeetingManagementSystemDbContext>(options => options.UseSqlServer
            (Configuration.ConnectionString));
        }
    }
}
