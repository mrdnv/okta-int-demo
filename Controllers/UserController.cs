using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using okta_integration_demo.Dtos;
using okta_integration_demo.Services.Interfaces;

namespace okta_integration_demo.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IOktaUserService oktaUserService;

        public UserController(IOktaUserService oktaUserService)
        {
            this.oktaUserService = oktaUserService;
        }

        [HttpPost("")]
        public async Task<IActionResult> PostUser(OktaUserDto userDto)
        {
            await oktaUserService.CreateUser(userDto);
            return Ok();
        }
    }


}