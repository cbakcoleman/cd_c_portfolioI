using Microsoft.AspNetCore.Mvc;

namespace cd_c_portfolio.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my Index!";
        } // END INDEX ROUTE

        [HttpGet]
        [Route("projects")]
        public string Projects()
        {
            return "These are my projects!";
        } // END PROJECTS ROUTE

        [HttpGet]
        [Route("contact")]
        public string Contact()
        {
            return "These are my digits!";
        } // END CONTACT ROUTE
    }

}