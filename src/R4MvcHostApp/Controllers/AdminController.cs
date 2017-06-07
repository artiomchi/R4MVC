using Microsoft.AspNetCore.Mvc;

namespace R4MvcHostApp.Controllers
{
    public partial class AdminController : Controller
    {
        // This class will clash with the Admin area name!

        public virtual void Test()
        {
            MVC.AdminArea.Users.Index();
            MVC.Admin.Test();
        }
    }
}
