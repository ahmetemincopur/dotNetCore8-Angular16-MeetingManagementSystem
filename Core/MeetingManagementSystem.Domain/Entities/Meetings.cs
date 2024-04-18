using MeetingManagementSystem.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingManagementSystem.Domain.Entities
{
    public class Meetings : BaseEntity
    {
        public required string Name { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required string Explanation { get; set; }
        public byte[]? UploadedDocument { get; set; }
    }
}
