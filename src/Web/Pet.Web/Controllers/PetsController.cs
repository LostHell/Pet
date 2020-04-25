namespace Pet.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PetsController : BaseController
    {
        public IActionResult Gallery()
        {
            return this.View();
        }
    }
}
