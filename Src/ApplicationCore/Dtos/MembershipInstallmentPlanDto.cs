using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Dtos
{
    public class MembershipInstallmentPlanDto
    {
        public int Number { get; set; }
        public string Duration { get; set; }


        public string GetName()
        {
            return Number + " " + Duration;
        }
    }
}
