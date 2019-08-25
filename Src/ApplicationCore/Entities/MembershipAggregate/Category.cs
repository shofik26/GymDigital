using ApplicationCore.Interfaces;
using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.MembershipAggregate
{
    public class Category : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int BranchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Active { get; set; }
    }
}
