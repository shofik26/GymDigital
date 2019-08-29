using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MembershipService : IMembership
    {
        private IAsyncRepository<Membership> _membershipRepository;

        public MembershipService(IAsyncRepository<Membership>  membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        public Membership CreateAsync(MembershipDto membershipDto)
        {
            var membership = new Membership();
            membership.Name = membershipDto.Name;
            membership.Category = membershipDto.Category;
            membership.Period = membershipDto.Period;
            membership.Limit = membershipDto.Limit;
            membership.LimitType = membershipDto.LimitType;
            membership.Amount = membershipDto.Amount;
            membership.SignupFee = membershipDto.SignupFee;
            membership.Description = membershipDto.Description;
            membership.Image = membershipDto.Image;
            membership.CreatedDate = DateTime.Now ;
            membership.UpdatedDate = DateTime.Now;
            membership.Active = true;

            return membership;
        }

        public Membership DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Membership>> GetAllMembership()
        {
            return _membershipRepository.ListAllAsync();
        }

        public Task GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Membership UpdateAsync(MembershipDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
