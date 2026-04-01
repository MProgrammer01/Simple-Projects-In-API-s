using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FistRestProject.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/MyFirstApi")]
    [ApiController]
    public class MyFirstApiController : ControllerBase
    {
        [HttpGet("EndPoint(Function) For Get Name")]
        public string GetMyName()
        {
            return "My Name Is : MProgrammer01";
        }

        [HttpGet("EndPoint(Function) For Get Age")]
        public string GetMyAge()
        {
            return "My Age Is : 22";
        }

        [HttpGet("EndPoint(Function) For Sum Tow Numbers")]
        public int SumTowNumbers(int num1,  int num2)
        {
            return num1 + num2;
        }

        [HttpGet("EndPoint(Function) For Multiple Tow Numbers")]
        public int MultipleTowNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
