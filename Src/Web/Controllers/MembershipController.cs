using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipController : ControllerBase
    {
        private readonly IAsyncRepository<Membership> _membershipRepository;
        private IMembership _membership;

        public MembershipController(
            IAsyncRepository<Membership> membershipRepository,
            IMembership membership)
        {
            _membershipRepository = membershipRepository;
            _membership = membership;
        }



        [HttpPost]
        public async Task<IActionResult> CreateMembership([FromBody]MembershipDto membershipDto)
        {
            var createMembership =_membership.CreateAsync(membershipDto);
             await _membershipRepository.AddAsync(createMembership);

            return Ok(createMembership);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateMembership([FromBody]MembershipDto membershipDto)
        {
            var updateMembership = _membership.UpdateAsync(membershipDto);
            await _membershipRepository.UpdateAsync(updateMembership);

            return Ok(updateMembership);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMembership()
        {
            var getMemberships = await _membership.GetAllMembership();

            return Ok(getMemberships);
        }
    }
}