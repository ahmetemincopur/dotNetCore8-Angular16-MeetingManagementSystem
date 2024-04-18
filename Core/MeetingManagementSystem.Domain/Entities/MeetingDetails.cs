using MeetingManagementSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Domain.Entities
{
    public class MeetingDetails : BaseEntity
    {
        public bool IsAttended {  get; set; }

        public required ICollection<User> Users { get; set; }
        public required Meeting Meeting { get; set; }  
    }
}
