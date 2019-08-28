using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MembershipInstallmentPlanService : IMembershipInstallmentPlan
    {
        public InstallmentPlan CreateInstallmentPlan(MembershipInstallmentPlanDto installmentPlanDto)
        {
            var installmentPlan = new InstallmentPlan();
            installmentPlan.Name = installmentPlanDto.GetName();
            installmentPlan.CreatedDate = DateTime.Now;
            installmentPlan.UpdatedDate = DateTime.Now;
            installmentPlan.Active = true;
           
            return installmentPlan;
        }

        public Task DeleteInstallmentPlan(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<InstallmentPlan>> GetAllInstallment()
        {
            throw new NotImplementedException();
        }
    }
}
