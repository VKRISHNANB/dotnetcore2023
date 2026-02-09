using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SecondWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Calculator/Add")] public int Add(int x,int y) { return x + y; }
        [HttpGet("Calculator/Subtract")] public int Subtract(int x,int y) { return x - y; }
    }
}
