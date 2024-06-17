using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateAdd { get; set; }
        public string TypeBreackdown { get; set; }
        public string DescriptionProblem { get; set; }
        public int EquipmentId { get; set; }
        public int ConditionId { get; set; }
        public int PriorityId { get; set; }

        public Equipment Equipment { get; set; }
        public Priority Priority { get; set; }
        public Condition Condition{ get; set; }

        public ICollection<Specialist> Specialists { get; set; }
    }
}
