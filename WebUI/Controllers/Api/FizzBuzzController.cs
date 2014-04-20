using System.Collections.Generic;
using System.Web.Http;
using FizzBuzzApplication;

namespace WebUI.Controllers.Api
{
    public class FizzBuzzController : ApiController
    {
	    private readonly IApplication _application;

	    public FizzBuzzController(IApplication application)
	    {
		    _application = application;
	    }

	    public IEnumerable<string> Get(int id)
	    {
		    return _application.Play(id);
	    }
    }
}
