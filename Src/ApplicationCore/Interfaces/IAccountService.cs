using ApplicationCore.Dtos;
using ApplicationCore.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IAccountService
    {
        Account Authenticate(string username, string password);
        IEnumerable<Account> GetAll();
        Account GetById(int id);
        Account Create(RegisterDto registerDto, string password);
        void Update(RegisterDto registerDto, string password = null);
        void Delete(int id);
        bool UserExists(string username, string email);
        string Login(LoginDto loginDto);
    }
}
