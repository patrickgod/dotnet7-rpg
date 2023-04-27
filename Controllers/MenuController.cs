using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;


namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private static List<Menu> menus = new List<Menu>//è mock!!
        {
            new Menu (),
            new Menu {Id=1, AppName="nuovaAppname"}
        };
        [HttpGet("GetuttiMenu")]
        public ActionResult<List<Menu>> Get()
        {
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(menus.FirstOrDefault(c => c.Id == id));
        }
    }
}
