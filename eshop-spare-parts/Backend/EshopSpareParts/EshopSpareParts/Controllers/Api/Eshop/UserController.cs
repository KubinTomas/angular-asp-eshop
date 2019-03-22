using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EshopSpareParts.Models;
using EshopSpareParts.Models.Db;
using EshopSpareParts.Models.DTO;
using EshopSpareParts.Services;
using System.Web.Http.Cors;

namespace EshopSpareParts.Controllers.Api.Eshop
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class UserController : ApiController
    {
        private ApplicationDbContext _context;
        private AccountService _service;

        public UserController(ApplicationDbContext contex, AccountService service)
        {
            _context = contex;
            _service = service;
        }

        [HttpPost, Route("api/create/user")]
        public async Task<IHttpActionResult> CreateUser(UserDto userDto)
        {
            var accountServiceDto = await _service.CreateUserAsync(userDto);
            
            return Created(new Uri(Request.RequestUri + accountServiceDto.UserDto.id.ToString()), accountServiceDto);
        }
        
        [HttpGet, Route("api/login/user/{email}/{password}")]
        public async Task<IHttpActionResult> LoginUser(string email, string password)
        {
            var userDto = new UserDto { email = email, password = password};

            var accountServiceDto = await _service.LoginUserAsync(userDto);

            return Ok(accountServiceDto);
        }
        [HttpGet, Route("api/get/user/{email}/{userId}")]
        public async Task<IHttpActionResult> GetUser(string email, int userId)
        {
            var accountServiceDto = await _service.GetUserAsync(email, userId);

            return Ok(accountServiceDto);
        }
        [HttpPut, Route("api/edit/user")]
        public async Task<IHttpActionResult> EditUser(UserDto userDto)
        {
            var accountServiceDto = await _service.EditUserAsync(userDto);

            return Ok(accountServiceDto);
        }
        [HttpGet, Route("api/user/isAdmin/{userId}")]
        public async Task<IHttpActionResult> IsUserAdmin(int userId)
        {
            var accountServiceDto = await _service.IsUserAdmin(userId);

            return Ok(accountServiceDto);
        }
        [HttpGet, Route("api/user/email/isAvailable/{email}")]
        public async Task<IHttpActionResult> IsEmailAvailable(string email)
        {
            return Ok(await _service.IsEmailAvailable(email));
        }


    }
}