using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace comicbookgal.Controllers
{
    public class comicsbookController :Controller
    {

        public ContentResult Detail() {

            return new ContentResult()
            {
                Content = "Hello from controller"
            };
        }
    }
}


