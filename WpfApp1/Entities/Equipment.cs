using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Equipment
    {
        public Equipment(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }

        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        
    }
}
