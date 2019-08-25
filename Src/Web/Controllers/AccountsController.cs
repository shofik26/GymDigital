using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Dtos;
using ApplicationCore.Entities.UserAggregate;
using ApplicationCore.Interfaces;
using AutoMapper;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountService _userService;
        private IMapper _mapper;
        private GymDigitalContext _context;

        public AccountsController(
            GymDigitalContext context,
            IAccountService userService,
            IMapper mapper)
        {
            _context = context;
            _userService = userService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]LoginDto userDto)
        {
            var user = _userService.Authenticate(userDto.Username, userDto.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto userRegisterDto)
        {
            if (userRegisterDto == null)
                return BadRequest("No registation data found");

            var usernameExists = _userService.UserExists(userRegisterDto.Username, userRegisterDto.Email);
            if (usernameExists)
                return BadRequest("Username or email already exits");

            var user = _userService.Create(userRegisterDto,userRegisterDto.Password);
            await _context.AddAsync(user);

            return Ok(user);

        }


        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginDto loginDto)
        {
            var jwtToken = _userService.Login(loginDto);

            if (jwtToken == null)
                return Unauthorized();

            return Ok(jwtToken);
        }
    }
}