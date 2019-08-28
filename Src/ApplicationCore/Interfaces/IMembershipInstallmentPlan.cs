using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IMembershipInstallmentPlan
    {
        Task<IReadOnlyList<InstallmentPlan>> GetAllInstallment();
        InstallmentPlan CreateInstallmentPlan(MembershipInstallmentPlanDto installmentPlanDto);
        Task DeleteInstallmentPlan(int id);
    }
}
