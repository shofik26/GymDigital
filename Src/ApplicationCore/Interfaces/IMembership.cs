using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
  
    public interface IMembership
    {
        Task<IReadOnlyList<Membership>> GetAllMembership();
        Task GetByIdAsync(int id);
        Membership CreateAsync(MembershipDto membershipDto);
        Membership UpdateAsync(MembershipDto categoryDto);
        Membership DeleteAsync(int id);
    }
}
