using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Account;
using InsideAPI.Common;
using InsideAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // GET: api/Account
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Account/5
        [HttpPost]
        public IActionResult Login(Login login)
        {
            ReturnResult<LoginResult> loginResult = new ReturnResult<LoginResult>();
            AccountService loginService = new AccountService();
            try
            {
                if (loginService.IsAuthenticate(login))
                {
                    var jwtToken = loginService.CreateToken();

                    UserSessionInfo.UserName = login.UserName;

                    loginResult.Item.token = jwtToken;
                    loginResult.ErrorCode = "0";
                    loginResult.ErrorMessage = "";
                }
                else
                {
                    loginResult.Item.token = string.Empty;
                    loginResult.ErrorCode = "1";
                    loginResult.ErrorMessage = "";
                }
            }
            catch(Exception ex)
            {
                loginResult.ErrorCode = "1";
                loginResult.ErrorMessage = ex.Message;
            }
            return Ok(loginResult);
        }

        // POST: api/Account
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Account/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
