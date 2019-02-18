using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mvcidentity.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcidentity.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ValuesController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var user = await _userManager.GetUserAsync(User);

            return Json(user.Favorites);

            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            user.Favorites.Add(new FavoriteColor { ColorName = "Blue", RGB = "0,0,255" });
            await _userManager.UpdateAsync(user);
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody]string value)
        {
            var user = await _userManager.GetUserAsync(User);
            user.Favorites.Add(new FavoriteColor { ColorName = "Blue", RGB = "0,0,255" });
            await _userManager.UpdateAsync(user);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
