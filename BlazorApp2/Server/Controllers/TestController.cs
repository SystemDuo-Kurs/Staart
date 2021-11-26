using Microsoft.AspNetCore.Mvc;

namespace BlazorApp2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Zklj()
            => "EVO SA SEEERVERA!";
    }
}
