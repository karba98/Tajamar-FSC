using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceAlexaMeme.Models;
using ServiceAlexaMeme.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ServiceAlexaMeme.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlexaController : ControllerBase
    {
        RepositoryMemes repo;
        public AlexaController(RepositoryMemes repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        public async Task<IActionResult> HandleResponse([FromBody] SkillRequest skillRequest)
        {
            HttpRequest httprequest = HttpContext.Request;

            //return ResponseBuilder.Ask("Ya tienes tus memes, cara bombilla", null);

            //bool valid = await ValidateRequest(httprequest, skillRequest);
            bool valid = true;
            if (!valid)
            {
                return new BadRequestResult();
            }
            //if (!skillRequest.Context.System.Device.IsInterfaceSupported("Display"))
            //{
            //    var notSupportedResponse = ResponseBuilder.Tell("No sirvo para dispositivos con pantalla");
            //    return new OkObjectResult(notSupportedResponse);
            //}

            SkillResponse response = null;

            if (skillRequest != null)
            {
                if(skillRequest.GetRequestType() == typeof(LaunchRequest))
                {
                    response = ResponseBuilder.Tell(repo.GetRandomMeme());
                    response.Response.ShouldEndSession = false;
                }
                else if (skillRequest.GetRequestType() == typeof(IntentRequest))
                {
                    // do some intent-based stuff
                    var intentRequest = skillRequest.Request as IntentRequest;
                    
                    // check the name to determine what you should do
                    if (intentRequest.Intent.Name.Equals("AddMeme"))
                    {
                        var newmeme = intentRequest.Intent.Slots["meme"].Value;
                        if (newmeme != null)
                        {
                            String added = repo.insertMeme(newmeme);
                            if (added=="OK")
                            {
                                response = ResponseBuilder.Tell("Menudo asco de meme, pero bueno, me lo guardo");
                                response.Response.ShouldEndSession = false;
                                return new ObjectResult(response);

                            }
                            else
                            {
                                response = ResponseBuilder.Tell("No he podido añadir tu meme, es un poco caquita"+added);
                                response.Response.ShouldEndSession = true;
                                return new ObjectResult(response);
                            }
                            
                        }
                        else
                        {
                            //response=  ResponseBuilder.Tell("Por ahora esta función se está construyendo, no me des la murga");
                            response= ResponseBuilder.Ask("¿Puedes decirme ese meme tan gracioso que se te ha ocurrido?",null);
                            response.Response.ShouldEndSession = false;
                        }
                    }
                    else if (intentRequest.Intent.Name.Equals("OtroMemeIntent"))
                    {
                        response = ResponseBuilder.Tell(repo.GetRandomMeme());
                        response.Response.ShouldEndSession = false;
                    }
                }

            }
            else
            {
                response = ResponseBuilder.Tell("No entendí ni verga jaja salu 2");

            }

            return new ObjectResult(response);




        }

        private static async Task<bool> ValidateRequest(HttpRequest request, SkillRequest skillRequest)
        {
            request.Headers.TryGetValue("SignatureCertChainUrl", out var signatureChainUrl);
            if (string.IsNullOrWhiteSpace(signatureChainUrl))
            {
                return false;
            }

            Uri certUrl;
            try
            {
                certUrl = new Uri(signatureChainUrl);
            }
            catch
            {
                return false;
            }

            request.Headers.TryGetValue("Signature", out var signature);
            if (string.IsNullOrWhiteSpace(signature))
            {
                return false;
            }

            request.Body.Position = 0;
            var body = await new StreamReader(request.Body).ReadToEndAsync();
            request.Body.Position = 0;

            if (string.IsNullOrWhiteSpace(body))
            {
                return false;
            }

            bool valid = await RequestVerification.Verify(signature, certUrl, body);
            bool isTimestampValid = RequestVerification.RequestTimestampWithinTolerance(skillRequest);

            if (!isTimestampValid)
            {
                valid = false;
            }

            return valid;
        }
    }
}
