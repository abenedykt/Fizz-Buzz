using System.Web.Mvc;
using FizzBuzzApplication;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IApplication _app;

	    public HomeController(IApplication app)
	    {
		    _app = app;
	    }

	    public ActionResult Index()
        {
            return View(_app.Play(2));
        }
	}
}