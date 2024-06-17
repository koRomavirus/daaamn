using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Specialist
    {
        public int SpecialistId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Post { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
