using System.Threading;
using System.Web.Mvc;
using Interview_Project.Data.Agents;

namespace Interview_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var agent = new PeopleDataAgent();
            ViewBag.People = agent.GetAllPeople();
            return View();
        }

        [HttpPost]
        public JsonResult GetPeople(SearchObject search)
        {
            if (search.IncludeDelay)
                Thread.Sleep(5000);
            var agent = new PeopleDataAgent();

            var list = agent.GetPeople(search.SearchValue);

            return Json(list);
        }

        public class SearchObject
        {
            public string SearchValue { get; set; }
            public bool IncludeDelay { get; set; }
        }
    }

    public class SearchValues
    {
        public string SearchValue;
    }
}