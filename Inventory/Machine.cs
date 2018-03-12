using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Panel
{
    class Machine
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }
        public int ITSNumber { get; set; }
        public string Status { get; set; }
        public Team Team { get; set; }
        public int Barcode { get; set; }
    }
}
