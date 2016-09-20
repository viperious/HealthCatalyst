using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using Interview_Project.Data;
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

        public class SearchObject
        {
            public string SearchValue { get; set; }
            public bool IncludeDelay { get; set; }
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


    }

    public class SearchValues
    {
        public string SearchValue;
    }
}