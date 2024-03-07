using auth_102.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace auth_102.Controllers
{
    [Route("/")]
    [ApiController]
    public class userController : ControllerBase
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public userController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

        }

        // GET: api/<userController>
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/<userController>/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // POST api/<userController>
        [HttpPost]
        [Route("/registers")]
        public async Task<IActionResult> Register(RegisterModel model)
        {

            var user = new ApplicationUser()
            {
                Fullname = model.Fullname,
                u_Roles = model.u_Roles,

                UserName = model.usename,
                PasswordHash = model.Password};

            var request = await userManager.CreateAsync(user, user.PasswordHash!);
            if (request.Succeeded)
            {
                return Ok("regiesterd succssfully ");
            }
            return BadRequest("error occured");
        }

        // PUT api/<userController>/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // DELETE api/<userController>/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
