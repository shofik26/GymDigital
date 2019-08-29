using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Dtos
{
    public class MembershipDto
    {
        public string Name { get; set; }
        public int Category { get; set; }
        public string Period { get; set; }
        public string Limit { get; set; }
        public string LimitType { get; set; }
        public decimal Amount { get; set; }
        public decimal SignupFee { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
