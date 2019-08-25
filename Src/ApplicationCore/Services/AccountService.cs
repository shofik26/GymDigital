using ApplicationCore.Entities.UserAggregate;
using ApplicationCore.Helpers;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using ApplicationCore.Dtos;

namespace ApplicationCore.Services
{
    public class AccountService : IAccountService
    {
        private List<Account> _users = new List<Account>
        {
            new Account{Id=1,Name="Admin User", Username="admin", Password="admin",Role= Role.Admin },
            new Account{Id=1,Name="Normal User", Username="user", Password="user",Role= Role.User }
        };

        private readonly AppSettings _appSetting;

        public AccountService(IOptions<AppSettings> appSettings)
        {
            _appSetting = appSettings.Value;
        }

        public Account Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSetting.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role,user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            // remove password before returning
            user.Password = null;

            return user;
        }


        public string Login(LoginDto loginDto)
        {
            var user = _users.Where(x => x.Username == loginDto.Username && x.Password == loginDto.Password).SingleOrDefault();

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSetting.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role,user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var jwtToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(jwtToken);
            return token;

        }

        public Account Create(RegisterDto registerDto, string password)
        {
            var createUser = new Account();
            createUser.Name = registerDto.getName();
            createUser.Username = registerDto.Username;
            createUser.Email = registerDto.Email;
            createUser.Password = registerDto.Password;
            createUser.Role = registerDto.Role;
            createUser.CreatedDate = DateTime.Now;
            createUser.UpdatedDate = DateTime.Now;
            createUser.Status = '1';

            return createUser;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(RegisterDto registerDto, string password = null)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string username, string email)
        {
            var users = _users.SingleOrDefault(x => x.Username == username || x.Email == email);

            if (users == null)
                return false;
            else
                return true;
        }
    }
}
