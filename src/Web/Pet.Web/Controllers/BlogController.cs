namespace Pet.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class BlogController : BaseController
    {
        public IActionResult Posts()
        {
            return this.View();
        }
    }
}
