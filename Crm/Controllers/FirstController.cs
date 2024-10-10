using Microsoft.AspNetCore.Mvc;

namespace Crm.Controllers{



    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }

}