using Microsoft.AspNetCore.Mvc;
using InternalAPI.Content;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;

namespace InternalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : Controller
    {
        [HttpGet]
        public object Get()
        {

            Token token = new Token();
            token.GenerateToken();
            if(token.bError == false)
            {
                //var response = new HttpResponseMessage(System.Net.HttpStatusCode.);
                return Ok(token);
            }
            else
            {
                var response = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                response.Content = new StringContent(JsonConvert.SerializeObject(token));
                return response;                
            }
        }

    }
}
