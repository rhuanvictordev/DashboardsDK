using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardsDK.Models
{
    public class DashboardModel
    {
        public List<SelectListItem> Lista { get; set; } = new List<SelectListItem>() 
        {
            new SelectListItem(){ Text = "Item1", Value = "Value1" },
            new SelectListItem(){ Text = "Item2", Value = "Value2" },
            new SelectListItem(){ Text = "Item3", Value = "Value3" }
        };
        public string SetorNome { get; set; }
        public int OpsAbertas { get; set; }
        public int QtdRefugo { get; set; }
        public double OEE { get; set; }
        public string Obs { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

    }
}