namespace Pet.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SubscriptionsController : BaseController
    {
        public IActionResult Price()
        {
            return this.View();
        }
    }
}
