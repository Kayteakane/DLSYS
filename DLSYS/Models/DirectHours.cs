using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DLSYS.Models
{

    public class DirectHours
    {
        public int id { get; set; }
        public string employee_id { get; set; }
        public string project { get; set; }
        public string variant { get; set; }
        public string node { get; set; }
        public string task { get; set; }
        public int week_num { get; set; }
        public decimal mon { get; set; }
        public decimal tue { get; set; }
        public decimal wed { get; set; }
        public decimal thu { get; set; }
        public decimal fri { get; set; }
        public decimal sat { get; set; }
        public decimal sun { get; set; }
        public string remarks{ get; set; }

    }
}