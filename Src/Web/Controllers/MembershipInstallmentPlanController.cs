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
    [Route("api/membership")]
    [ApiController]
    public class MembershipInstallmentPlanController : ControllerBase
    {
        private readonly IAsyncRepository<InstallmentPlan> _installementPlanRepository;
        private IMembershipInstallmentPlan _installemtnPlan;

        public MembershipInstallmentPlanController(
            IAsyncRepository<InstallmentPlan> installmentPlanRepository,
            IMembershipInstallmentPlan installmentPlan)
        {
            _installementPlanRepository = installmentPlanRepository;
            _installemtnPlan = installmentPlan;
        }


        [HttpPost]
        [Route("plan")]
        public async Task<IActionResult> Create([FromBody]MembershipInstallmentPlanDto installmentPlanDto)
        {
            var plan = _installemtnPlan.CreateInstallmentPlan(installmentPlanDto);

           await  _installementPlanRepository.AddAsync(plan);

            return Ok(plan);
        }
    }
}