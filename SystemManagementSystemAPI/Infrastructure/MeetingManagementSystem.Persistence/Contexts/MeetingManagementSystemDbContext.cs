using MeetingManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Persistence.Contexts
{
    public class MeetingManagementSystemDbContext : DbContext
    {
        public MeetingManagementSystemDbContext(DbContextOptions options) : base(options) 
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingDetails> MeetingDetails { get; set; }   
    }
}
