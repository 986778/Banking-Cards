using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Card.Models;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Card.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Content obj;
            List<Content> lobj = new List<Content>();

            obj = new Content();
            obj.title = "Card Layout 1";
            obj.text = "Banking Application 1 Card.";
            obj.img = "https://finezza.in/blog/wp-content/uploads/2021/03/10-Must-Have-Features-Benefits-of-Mobile-Banking-Apps-in-2021.jpg";
            lobj.Add(obj);

            obj = new Content();
            obj.title = "Card Layout 2";
            obj.text = "Banking Application 2 Card.";
            obj.img = "https://img.freepik.com/free-vector/banking-app-interface-screens_23-2148604478.jpg";
            lobj.Add(obj);

            obj = new Content();
            obj.title = "Card Layout 3";
            obj.text = "Banking Application 3 Card.";
            obj.img = "https://assets-global.website-files.com/5db1c0d5ca3871e8fd1a7b66/602d3abef69d9a6993226f88_Frame%202.png";
            lobj.Add(obj);

            obj = new Content();
            obj.title = "Card Layout 4";
            obj.text = "Banking Application 4 Card.";
            obj.img = "https://c8.alamy.com/comp/BN743J/atm-machine-bangkok-thailand-BN743J.jpg";
            lobj.Add(obj);



            return View(lobj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}