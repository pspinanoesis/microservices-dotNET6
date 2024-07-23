using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatortController : ControllerBase
    {
        

        private readonly ILogger<CalculatortController> _logger;

        public CalculatortController(ILogger<CalculatortController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sUM/{firstNumber}/{secondNumber}")]
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private int ConvertToDecimal(string number)
        {
            throw new NotImplementedException();
        }

        private bool IsNumeric(string number)
        {
            throw new NotImplementedException();
        }
    }
}
