using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExplosiveAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("mumble")]
    public string Mumbling (string s) 
    {  
        var rv = "";
        for (var i = 0; i < s.Count(); i++)
        {
        for (var j = 0; j <= i; j++)
        {
            if (j == 0)
            {
            rv += s[i].ToString().ToUpper();
            }
            else
            {
            rv += s[i].ToString().ToLower();
            }
        }
        rv += "-";
        }
        return rv.TrimEnd('-');
    }
  }
}