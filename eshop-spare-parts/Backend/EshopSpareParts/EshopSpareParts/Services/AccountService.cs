using EshopSpareParts.Models;
using EshopSpareParts.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AutoMapper;
using System.Net;
using System.Data.Entity;
using EshopSpareParts.Models.Db;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.Security.Principal;
using EshopSpareParts.Models.DTO.ServicesReturnClasses;
using EshopSpareParts.Models.CustomReturnCodes;
using EshopSpareParts.Models.PasswordHashers;

namespace EshopSpareParts.Services
{
    public class AccountService : Service
    {

        private ApplicationDbContext _context;

        private readonly byte[] key = Encoding.ASCII.GetBytes("qewqeasdasasdasd654qw54x5c56as8dsasdxca54d565asd89qasd");

        public AccountService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<AccountServiceDto> CreateUserAsync(UserDto userDto)
        {
            var user = Mapper.Map<UserDto, User>(userDto);
            user.Created = DateTime.Now;
            user.AgreeTransaction = true;
            user.Password = PasswordHash.HashPassword(user.Password);

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            userDto.id = user.Id;
            userDto.token = GenerateJwtToken(user);

            return new AccountServiceDto { UserDto = userDto, StatusCode = ReturnCodes.Created };
        }
        public async Task<AccountServiceDto> LoginUserAsync(UserDto userDto)
        {
            var userInDb = await _context.Users.SingleOrDefaultAsync(c => c.Email == userDto.email);

            if (userInDb == null)
                return new AccountServiceDto { UserDto = userDto, StatusCode = ReturnCodes.NotFound };

            if (!PasswordHash.VerifyHashedPassword(userInDb.Password, userDto.password))
                return new AccountServiceDto { UserDto = userDto, StatusCode = ReturnCodes.NotFound };


            userDto.id = userInDb.Id;
            userDto.token = GenerateJwtToken(userInDb);

            return new AccountServiceDto { UserDto = userDto, StatusCode = ReturnCodes.Ok };
        }

        public async Task<AccountServiceDto> IsUserAdmin(int userId)
        {
            var userInDb = await _context.Users.SingleOrDefaultAsync(c => c.Id == userId);

            if (userInDb == null)
                return new AccountServiceDto { StatusCode = ReturnCodes.NotFound };


            return new AccountServiceDto { UserDto = new UserDto { isAdmin = userInDb.IsAdmin }, StatusCode = ReturnCodes.NotFound };
        }

        public async Task<bool> IsEmailAvailable(string email)
        {
            return !await _context.Users.AnyAsync(c => c.Email == email);
        }
        public async Task<AccountServiceDto> GetUserAsync(string email, int userId)
        {
            var userInDb = await _context.Users.SingleOrDefaultAsync(c => c.Id == userId && c.Email == email);

            if (userInDb == null)
                return new AccountServiceDto {StatusCode = ReturnCodes.BadRequest };

            var userDto = Mapper.Map<User, UserDto>(userInDb);

            return new AccountServiceDto { UserDto = userDto, StatusCode = ReturnCodes.Ok };

        }
        public async Task<AccountServiceDto> EditUserAsync(UserDto userDto)
        {
            var userInDb = await _context.Users.SingleOrDefaultAsync(c => c.Id == userDto.id && c.Email == userDto.email);

            if (userInDb == null)
                return new AccountServiceDto { StatusCode = ReturnCodes.BadRequest };

            userInDb.Name = userDto.name;
            userInDb.Surname = userDto.surname;
            userInDb.PhoneNumber = userDto.phoneNumber;

            userInDb.Town = userDto.town;
            userInDb.TownNumber = userDto.townNumber;
            userInDb.TownStreet = userDto.townStreet;

            await _context.SaveChangesAsync();

            return new AccountServiceDto { UserDto = userDto, StatusCode = ReturnCodes.Ok };

        }
        public string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var wroteToken = tokenHandler.WriteToken(token);

            return wroteToken;
        }


    }
}