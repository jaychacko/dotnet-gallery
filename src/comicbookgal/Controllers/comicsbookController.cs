using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace comicbookgal.Controllers
{
    public class comicsbookController :Controller
    {

        public ActionResult Detail() {

            if (DateTime.Today.DayOfWeek== DayOfWeek.Sunday)

            {
                return Redirect ("/");
            }

            return Content("hello from detail");
          
        }
    }
}


