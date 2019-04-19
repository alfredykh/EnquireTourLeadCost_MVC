using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnquireTourLeadCost.Models
{
    public class TourLead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string Rank { get; set; } //M1, M2, M3, PT
        public int DailyRate { get; set; }
        public int Day { get; set; }
    }
}