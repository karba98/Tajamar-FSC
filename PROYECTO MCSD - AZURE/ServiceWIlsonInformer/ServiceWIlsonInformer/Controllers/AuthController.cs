using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

using ServiceWIlsonInformer.Helpers;
using ServiceWIlsonInformer.Models;
using ServiceWIlsonInformer.repositories;
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
        HelperToken helper;
        IRepositoryUsuarios repo;
        public AuthController(HelperToken helper,IRepositoryUsuarios repo)
        {
            this.repo = repo;
            this.helper = helper;
        }
        [Authorize]
        [HttpPost]
        [Route("insertuser")]
        public IActionResult Insert(Usuario user)
        {
            try
            {
                repo.InsertUsuario(user.Nombre, user.User, user.Apellido, user.Email, user.Rol,user.Salt,user.Pass);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [Authorize]
        [HttpGet]
        [Route("exist/{username}/{email}")]
        public IActionResult Exist(String username,String email)
        {
            try
            {
                return Ok(repo.Exist(username,email));
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
        [Authorize]
        [HttpGet]
        [Route("validate")]
        public IActionResult ValidaToken()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            
            Usuario usuario =
                this.repo.Check(model.UserName
                , model.Password);
            if (usuario != null)
            {

                Claim[] claims = new[]
                {
                new Claim("UserData",
                JsonConvert.SerializeObject(usuario))
            };

                JwtSecurityToken token = new JwtSecurityToken
                    (
                        issuer: helper.Issuer
                        , audience: helper.Audience
                        , claims: claims
                        , expires: DateTime.UtcNow.AddMinutes(15)
                        , notBefore: DateTime.UtcNow
                        , signingCredentials:
                            new SigningCredentials(this.helper.GetKeyToken(), SecurityAlgorithms.HmacSha256)
                    );

                return Ok(
                    new
                    {
                        user = usuario,
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
