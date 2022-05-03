using ApiEmpleadosOAuth.Helpers;
using ApiEmpleadosOAuth.Models;
using ApiEmpleadosOAuth.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiEmpleadosOAuth.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        RepositoryEmpleados repo;
        HelperToken helper;
        public AuthController(HelperToken helper, RepositoryEmpleados repo)
        {
            this.repo = repo;
            this.helper = helper;
        }
        
        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel model)
        {
            /*
             * ESTO ES LO QUE SE ENVIA
            {
	            "UserName":"SALA",
	            "Password":"7521"
            }
             */
            Empleado emp = repo.ExisteEmpleado(model.UserName, int.Parse(model.Password));
            if(emp == null) { return Unauthorized(); }
            else
            {
                //almacenar usuario en el token con claim
                //y devolver todo el token
                String empleadojson = JsonConvert.SerializeObject(emp);
                Claim[] claims = new[] { 
                    new Claim("UserData",empleadojson)
                };

                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: helper.Issuer,
                    audience: helper.Audience,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    notBefore: DateTime.UtcNow,
                    claims:claims,
                    signingCredentials: 
                    new SigningCredentials(
                            helper.GetKeyToken(),
                            SecurityAlgorithms.HmacSha256
                        )
                    );
               
                return Ok(
                    //esto es un json de "response":"nkfjgjhdgsggsjkdhgjkghsk"
                    new
                    {
                        response=new JwtSecurityTokenHandler().WriteToken(token)
                    }
                    );
            }
        }
    }
}
