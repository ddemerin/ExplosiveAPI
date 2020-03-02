using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("explode")]
    public string Explode (string s)
    {
        var answer = "";
        foreach (var letter in s)
        {
        var number = int.Parse(letter.ToString());
        for (var i = 0; i < number; i++)
        {
            answer += letter;
        }
        }
        return answer;
    }
  }
}