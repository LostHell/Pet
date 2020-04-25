namespace Pet.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : BaseController
    {
        public IActionResult ContactMe()
        {
            return this.View();
        }
    }
}
