using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MatthewStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult SGroupView()
        {
            List<Models.StudyGroupClass> StudyGroup = new List<Models.StudyGroupClass>();
            StudyGroup.Add(new Models.StudyGroupClass { stNumber = "u2894312", FirstName = "Matthew", LastName = "Frohlich", Email = "matthewf@gmail.com", myLink = "~/HTML/Matthew.html", Delete = "del"});
            StudyGroup.Add(new Models.StudyGroupClass { stNumber = "u24946788", FirstName = "Nikhil", LastName = "Sunker", Email = "Niks@gmail.com", myLink = "~/HTML/Nikhil.html",Delete = "del" });
            StudyGroup.Add(new Models.StudyGroupClass { stNumber = "u24765484", FirstName = "Siyanda", LastName = "Twala", Email = "Siyat@gmail.com", myLink = "~/HTML/Siyanda.html", Delete = "del" });
            StudyGroup.Add(new Models.StudyGroupClass { stNumber = "u24876567", FirstName = "Aman", LastName = "Singh", Email = "Amans@gmail.com", myLink = "~/HTML/Aman.html", Delete = "del" });
            StudyGroup.Add(new Models.StudyGroupClass { stNumber = "u24686389", FirstName = "Tyla", LastName = "Naidoo", Email = "Tylan@gmail.com", myLink = "~/HTML/Tyla.html", Delete = "del" });
            return View(StudyGroup);
        }
    }
}