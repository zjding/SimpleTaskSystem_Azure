using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using Abp.Domain.Entities;

namespace SimpleTaskSystem.Tasks.Dtos
{
    public class TaskDto : Entity<long>
    {
        public int AssignedPersonId { get; set; }
        public string AssignedPersonName { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public byte State { get; set; }
    }
}
