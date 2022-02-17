using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class FizzBuzzController : ControllerBase
{

    [HttpGet(Name = "{inputNumber")]
    public IActionResult Get(string inputNumber)
    {
        if (!int.TryParse(inputNumber, out var isNumber))
        {
            return BadRequest("You did not provide a number. Try again");
        }

        return Ok(inputNumber);
    }
}