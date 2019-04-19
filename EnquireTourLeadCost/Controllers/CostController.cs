using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using EnquireTourLeadCost.DB;
using EnquireTourLeadCost.Models;
using System.Diagnostics;


namespace EnquireTourLeadCost.Controllers
{
    public class CostController : Controller
    {
        // GET: Cost

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Calculate(int Id, int Day)
        {
            TourLead lead = TourLeaderData.GetTourLeaderById(Id);

            string name = lead.Name;
            string Rank = lead.Rank;

            int DailyRate = 0;
            int cost = 0;
            //if (Id == null)
            //{
            //    return View();
            //}
            //else
            //{

            if (Rank == "M1")
            {
                DailyRate = 500;
            }
            else if (Rank == "M2")
            {
                DailyRate = 400;
            }
            else if (Rank == "M3")
            {
                DailyRate = 300;
            }
            //}
            cost = DailyRate * Day;
            ViewData["cost"] = cost;
            ViewData["Id"] = Id;
            ViewData["Name"] = name;
            ViewData["Rank"] = Rank;
            return View();
        }
    }
}
