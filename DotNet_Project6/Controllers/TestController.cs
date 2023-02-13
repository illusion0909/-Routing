using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet_Project6.Controllers
{
    [RoutePrefix("mytest")]
    public class TestController : Controller
    {
        // GET: Test
        [Route("Testing")]
        public ActionResult Index()
        {
            return View();
        }

    // [Route("aaa")]
        //[NonAction]
        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult aaa(int? id)
      [Route("abc")]
        public ActionResult aaa()
        {
            return View();
        }
       
    
     
        [ActionName("Find")]
        public ActionResult Search()
        {
            return View("Search");
        }
    }
}