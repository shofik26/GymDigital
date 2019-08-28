using ApplicationCore.Interfaces;
using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entities.MembershipAggregate
{
    public class InstallmentPlan : BaseEntity, IAggregateRoot
    {
        [Required]
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool Active { get; set; }
    }
}
