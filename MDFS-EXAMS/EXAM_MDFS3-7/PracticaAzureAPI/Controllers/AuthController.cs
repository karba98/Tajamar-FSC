using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using PracticaAzureAPI.Helpers;
using PracticaAzureAPI.Models;
using PracticaAzureAPI.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracticaAzureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        RepositorySeries repo;
        HelperToken helper;
        public AuthController(RepositorySeries repo, HelperToken helper)
        {
            this.repo = repo;
            this.helper = helper;
        }



        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            UsuarioAzure empleado =
                this.repo.Existeusuario(model.UserName
                , model.Password);
            if (empleado != null)
            {

                Claim[] claims = new[]
                {
                new Claim("UserData",
                JsonConvert.SerializeObject(empleado))
            };

                JwtSecurityToken token = new JwtSecurityToken
                    (
                        issuer: helper.Issuer
                        , audience: helper.Audience
                        , claims: claims
                        , expires: DateTime.UtcNow.AddMinutes(10)
                        , notBefore: DateTime.UtcNow
                        , signingCredentials:
                            new SigningCredentials(this.helper.GetKeyToken(), SecurityAlgorithms.HmacSha256)
                    );

                return Ok(
                    new
                    {
                        response =
                        new JwtSecurityTokenHandler().WriteToken(token)
                    });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
        
}
