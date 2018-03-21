using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Panel
{
    class InUseEquipment
    {
        public int ID {get;set;}
        public int Employee { get; set; }
        public string EmployeeName { get; set; }
        public int Equipment { get; set; }
        public string EquipmentType { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public string StatusOut { get; set; }
        public string StatusIn { get; set; }
        public string Note { get; set; }
    }
}
