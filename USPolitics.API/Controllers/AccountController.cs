using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using USPolitics.Service.DTOs;
using USPolitics.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace USPolitics.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountManager _accountManager;

        public AccountController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        [HttpPost]
        public IActionResult Register([FromBody]RegisterDTO registerDto)
        {
            _accountManager.Register(registerDto);
            return Ok();
        }

        [HttpPost]
        public IActionResult Login([FromBody]LoginDTO loginDto)
        {
            var result = _accountManager.Login(loginDto);
            if(Convert.ToBoolean(result.GetValue("success")) == true)
            {
                return Ok(result);
            }
            else 
            {
                return Unauthorized();
            }           
        }
    }
}
