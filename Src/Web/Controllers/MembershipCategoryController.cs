using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Interfaces;
using AutoMapper;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/membership")]
    [ApiController]
    public class MembershipCategoryController : ControllerBase
    {
        private IMapper _mapper;
        private IAsyncRepository<Category> _categoryRepository;
        private IMembershipCategory _category;

        public MembershipCategoryController(
            IAsyncRepository<Category> categoryRepository,
            IMembershipCategory category,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _category = category;
            _mapper = mapper;
        }
        

        [HttpPost]
        [Route("category")]
        public async Task<IActionResult> Create([FromBody]MembershipCategoryDto  categoryDto)
        {
            if (categoryDto == null)
                return BadRequest("No data found");

            var catagory = _category.CreateAsync(categoryDto);

            return Ok(categoryDto);


        }
    }
}