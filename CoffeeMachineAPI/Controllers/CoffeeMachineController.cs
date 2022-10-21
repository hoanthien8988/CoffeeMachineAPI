using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMachineAPI.Controllers
{
    [ApiController]
    public class CoffeeMachineController : ControllerBase
    {
        private static int noOfCall = 1;

        [HttpGet]
        [Route("brew-coffee")]
        public async Task<ActionResult<CoffeeMachine>> Get()
        {
            if (noOfCall < 5)
            {
                noOfCall++;
                DateTime today = DateTime.Today;
                if (today.Day == 1 && today.Month == 4)
                {
                    return this.StatusCode(StatusCodes.Status418ImATeapot, string.Empty);
                }
                CoffeeMachine machine = new()
                {
                    Message = "Your piping hot coffee is ready",
                    Prepared = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK")
                };
                return Ok(machine);
            }
            else
            {
                return this.StatusCode(StatusCodes.Status503ServiceUnavailable, string.Empty);
            }
        }
    }
}
