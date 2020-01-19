using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFitnessApp.Models;


namespace MyFitnessApp.Controllers
{
    public class MembershipController : Controller
    {
        // GET: Membership
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MemberInfo(int memID, string memName, int memAge, string memGender)
        {
            Members m = new Members()
            {
                ID = memID,
                name = memName,
                gender = memGender,
                age = memAge
            };
            return View("MemberConfirm", m);
        }
        public ActionResult MemberInfo()
        {
            return View();
        }
        public ActionResult BMICalculator()
        {
            return View();
        }
        public ActionResult MemberList()
        {
            return View();
        }
        public ActionResult FeatureSuggestionForm()
        {
            return View();
        }
    }
}