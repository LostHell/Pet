namespace Pet.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ServicesController : BaseController
    {
        public IActionResult Service()
        {
            return this.View();
        }
    }
}
