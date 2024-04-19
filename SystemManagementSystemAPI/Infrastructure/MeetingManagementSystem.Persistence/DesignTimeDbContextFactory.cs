using MeetingManagementSystem.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MeetingManagementSystemDbContext>
    {
        public MeetingManagementSystemDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MeetingManagementSystemDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer
                (Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
