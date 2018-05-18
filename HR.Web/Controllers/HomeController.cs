using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new HR.DataModel.DAL.HumanResourceContext())
            {
                    int count = context.Departments.Local.Count; // before loading

                    context.Departments.Load();
                    count = context.Departments.Local.Count; // after loading

                    var query = from d in context.Departments.Local
                                where (d.Name == "Sales")
                                select d;
                
                    foreach (var d in query)
                    {
                        string a = string.Format("{0}: {1}", d.Id, d.Name);
                    }
            }

            return View();
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