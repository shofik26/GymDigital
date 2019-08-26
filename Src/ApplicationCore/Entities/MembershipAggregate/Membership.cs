using ApplicationCore.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.MembershipAggregate
{
    public class Membership: BaseEntity
    {
        public string Name { get; set; }
        public int Category { get; set; }
        public string Period { get; set; }
        public string Limit { get; set; }
        public string LimitType { get; set; }
        public decimal Amount { get; set; }
        public string Class { get; set; }
        public decimal Installment { get; set; }
        public string InstallmentPlan { get; set; }
        public decimal SignupFee { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Active { get; set; }
    }
}
