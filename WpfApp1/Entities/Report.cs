using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Report
    {
        public int ReportId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Materials { get; set; }
        public decimal Cost { get; set; }
        public string ReasonBreackdown { get; set; }
        public string AssistanceProvided { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}
