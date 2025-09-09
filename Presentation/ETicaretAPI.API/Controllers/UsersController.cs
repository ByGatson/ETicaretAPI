using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public ActionResult<bool> Index()
        {
            return CreatedAtAction("getById", false);

        }
    }
}
