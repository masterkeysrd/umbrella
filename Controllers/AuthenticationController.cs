using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using umbrella.Utils;
using umbrella.ViewModels;

namespace umbrella.Controllers
{
    [Route("api/v1/auth")]
    public class AuthenticationController : Controller
    {
        private IConfiguration configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] UserAuthVM user)
        {
            if (user == null)
            {
                return BadRequest("Solitud del cliente invalida.");
            }

            if (user.UserName == "user" && user.Password == "12345")
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration[ConfigurationConstants.JWT_KEY]));
                var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: configuration[ConfigurationConstants.JWT_ISSUER],
                    audience: configuration[ConfigurationConstants.JWT_ISSUER],
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signingCredentials
                    );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
