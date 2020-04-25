namespace Pet.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class VeterinarianController : BaseController
    {
        public IActionResult OurTeam()
        {
            return this.View();
        }
    }
}
