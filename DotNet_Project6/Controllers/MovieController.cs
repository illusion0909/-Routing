using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet_Project6.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [Route("movie/dateofrelese/{month:regex(\\d{2}):range(1,12)}/{year}")]
        public ActionResult ReleseDate(int month,int year)
        {
            return Content(month + "/" + year);
        }
        
    }
}